'   ACCycle
' Program to control my observatory air conditioner.
' 
' Uses the program UU.W32.exe to communicate with the Digilogger Power Controller to turn the AC power on/off.
'
' Operates in 3 modes:
' Manual - user turns air conitioner on/off by clicking the button
' 
' Time - AC is turned on between 2 specified times
'
' Temperature = read temperature from an Arduino via COM Port (USB), turn the AC on if temp is above high limit, 
'    off if below lower limit.
'
' Creates several outputs, depending on options selected
'
' Excel file (csv format) - this could be used to plot temperature over time
'
' Graph image - saved every morning, and every time  the graph is updated. Can be either .jpg or .png format.
'
' Boltwood image - used to send the current temperature back to Weather Display on the main computer.
'
' version 1.1.0.0 - saving the temperature limits, and the current control mode (manual, temp, time). 
'                   When program restarts it resumes in the previous mode.
'         1.2.0.0 - comment out graph ssaving to see if program still goes into background mode
'         1.3.0.0 - Added log messages for manual and timed On.Off changes
'                   Fixed date formatting

Imports System.Threading        ' to get Sleep function?
Imports System.IO

Public Class Form1
    Dim iRunning As Boolean         ' remember whether AC is running or not

    Private Const DEBUG_HAVE_PROG As Boolean = True
    Const NORMAL_WINDOW = 1                 ' Constants for running DigiLogger Power Switch
    Const DIGILOGGERPROG = "C:\Program Files (x86)\ACP Obs Control\Scripts\Brew\UU.W32.exe"
    Const OnCommand = "192.168.1.40 admin:1552 8on"
    Const OffCommand = "192.168.1.40 admin:1552 8off"
    Dim objShell        ' used to run external program

    ' colors for control buttons
    Private ACTIVE_COLOR As Color = Color.Green
    Private INACTIVE_COLOR As Color = Color.Transparent

    ' colors for mode tables
    Private ACTIVE_TABLE_COLOR As Color = Color.LightGreen
    Private INACTIVE_TABLE_COLOR As Color = Color.Transparent

    Private controlMode As Integer          ' tracking which control mode we are using
    Private Const MODE_TIME = 1
    Private Const MODE_TEMP = 2
    Private Const MODE_MANUAL = 3

    Dim DataFile As System.IO.StreamWriter                  ' Data file for Excel

    Dim rand As Random = New Random()

    Private Sub OpenSerialPort()
        If (SerialPort1.IsOpen) Then
            SerialPort1.Close()
        End If

        On Error Resume Next
        SerialPort1.PortName = CommPortBox.Text
        If (Err.Number > 0) Then
            LogMyMsg(Err.Description)
        End If
        On Error Resume Next
        SerialPort1.Open()
        If (Err.Number > 0) Then
            LogMyMsg(Err.Description)
        Else
            VerboseMsg("Comm Port " & SerialPort1.PortName & " has been opened")
        End If
    End Sub

    Private Sub OpenDataLogFile()
        ' This is the log file used to collect data for plotting in Excel, etc
        If (Not IsNothing(DataFile)) Then       ' dataFile is open
            DataFile.Close()
            DataFile.Dispose()
        End If

        If (cbLogExcelData.Checked) Then
            Try
                DataFile = New System.IO.StreamWriter(txtDataPath.Text, True)
                DataFile.WriteLine("Date,Time,DegreesC Port1,DegreesC Port2")
            Catch ex As Exception
                LogMyMsg("error opening Data Log File for " & txtDataPath.Text & vbCrLf & Err.Description)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iRunning = False
        Dim FileVer As String = FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion
        Me.Text = Me.Text & " Version " & FileVer
        objShell = CreateObject("Shell.Application")

        InitializeSettings()
        InitGraphData()
        OpenSerialPort()
        OpenDataLogFile()

        Select Case (controlMode)
            Case MODE_MANUAL
                SetACPower(False)
                btnEnableManual_Click(sender, e)
            Case MODE_TEMP
                btnEnableTemp_Click(sender, e)
            Case MODE_TIME
                btnEnableTime_Click(sender, e)
        End Select

    End Sub

    Private Sub InitializeSettings()
        Dim probeNum As Integer

        CommPortBox.Text = My.Settings.CommPort
        probeNum = My.Settings.ProbeNum
        opProbe1.Checked = (probeNum = 1)
        opProbe2.Checked = (probeNum = 2)
        txtTimerValue.Text = My.Settings.timerMsec
        ckVerbose.Checked = My.Settings.verbose
        txtBoltwoodPath.Text = My.Settings.BoltwoodPath
        cbLogExcelData.Checked = My.Settings.LogExcelData
        txtDataPath.Text = My.Settings.ACCycleTempDataPath
        cbMakeWebFile.Checked = My.Settings.MakeWebFile
        txtWebFile.Text = My.Settings.WebFilePath
        txtHighTemp.Text = CStr(My.Settings.HighTemp)
        txtLowTemp.Text = CStr(My.Settings.LowTemp)
        controlMode = My.Settings.LastControlMode
    End Sub

    Private Sub SaveMySettings()
        My.Settings.CommPort = CommPortBox.Text
        If (opProbe1.Checked) Then
            My.Settings.ProbeNum = 1
        End If
        If (opProbe2.Checked) Then
            My.Settings.ProbeNum = 2
        End If
        My.Settings.timerMsec = txtTimerValue.Text
        My.Settings.verbose = ckVerbose.Checked
        My.Settings.BoltwoodPath = txtBoltwoodPath.Text
        My.Settings.LogExcelData = cbLogExcelData.Checked
        My.Settings.ACCycleTempDataPath = txtDataPath.Text
        My.Settings.MakeWebFile = cbMakeWebFile.Checked
        My.Settings.WebFilePath = txtWebFile.Text
        My.Settings.HighTemp = CDbl(txtHighTemp.Text)
        My.Settings.LowTemp = CDbl(txtLowTemp.Text)
        My.Settings.LastControlMode = controlMode
        My.Settings.Save()
    End Sub

    Private Sub Form1_Unload(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        SaveMySettings()
        SerialPort1.Close()
        If (Not IsNothing(DataFile)) Then       ' dataFile is open
            DataFile.Close()
            DataFile.Dispose()
        End If

    End Sub

    Sub SetACPower(turnOn)
        Dim lightBitmap As Bitmap

        If (turnOn) Then
            ' switch to lightOn image 
            lightBitmap = My.Resources.lightOn
            If (DEBUG_HAVE_PROG) Then
                objShell.ShellExecute(DIGILOGGERPROG, OnCommand, , , NORMAL_WINDOW)
                VerboseMsg("Run command to turn ON AC")
            End If
            iRunning = True
        Else
            ' switch to light off
            lightBitmap = My.Resources.lightOff
            If (DEBUG_HAVE_PROG) Then
                objShell.ShellExecute(DIGILOGGERPROG, OffCommand, , , NORMAL_WINDOW)
                VerboseMsg("Run command to turn OFF AC")
            End If
            iRunning = False
        End If
        imOnOffLight.Image = lightBitmap  ' Image.FromFile(lightFileName)
    End Sub

    Function GetCurrTemp() As Double
        Dim rets
        Dim degF As Double
        Dim degC As Double
        Dim tokenArr As String()

        If (Not SerialPort1.IsOpen) Then
            ' when supplying fake data, don't need voltages
            rets = FormatNumber(RandTemp(75.0, 10), 2) & " " & FormatNumber(RandTemp(75.0, 10), 2) & " F " & FormatNumber(RandTemp(75.0, 10), 2) & " " & FormatNumber(RandTemp(75.0, 10), 2) & " C"
        Else
            ' read the temperature
            rets = SendReceive("T")
        End If
        ' rets is 196.07 192.01 F 91.15 88.90 C 1.41 1.39 V
        ' where the two sensors are reported for degF, degC, and the Voltages

        ' parse the return string
        tokenArr = rets.ToString.Split(" ")
        ' Zero based array, so tokenArr(0) is 196.07, ...
        ' return the degF value corresponding to whichever temperature probe
        ' is being used to control AC
        If (opProbe2.Checked) Then
            degF = CDbl(tokenArr(1))
            degC = CDbl(tokenArr(4))
        Else
            degF = CDbl(tokenArr(0))
            degC = CDbl(tokenArr(3))
        End If

        ' Update the screen values
        lblDegF1.Text = FormatNumber(CDbl(tokenArr(0)), 2)
        lblDegC1.Text = FormatNumber(CDbl(tokenArr(3)), 2)
        lblDegF2.Text = FormatNumber(CDbl(tokenArr(1)), 2)
        lblDegC2.Text = FormatNumber(CDbl(tokenArr(4)), 2)
        lblTimeStamp.Text = "As of " & Now().ToString("MM/dd/yyyy hh:mm tt")

        ' Write the Boltwood file for Weather Display, using degC being controlled
        WriteBoltwoodFile(degC)
        WriteACDataLog(CDbl(tokenArr(3)), CDbl(tokenArr(4)))
        AddToGraph(CDbl(tokenArr(0)), CDbl(tokenArr(1)))

        GetCurrTemp = degF
    End Function

    Function SendReceive(outmsg)
        Dim s

        SerialPort1.Write(outmsg)
        VerboseMsg("  Sent string {" & outmsg & "}")
        s = ""
        Thread.Sleep(800)
        s = SerialPort1.ReadLine

        VerboseMsg("  Received string {" & s & "}")
        SendReceive = s
    End Function

    Sub WriteBoltwoodFile(degC)
        '       The fields mean:
        '       Heading Col’s Meaning
        '       Date 1-10 local date yyyy-mm-dd
        '       Time 12-22 local time hh:mm:ss.ss (24 hour clock)
        '       T 24 temperature units displayed and in this data, 'C' for Celsius or 'F' for Fahrenheit
        '       V 26 wind velocity units displayed and in this data, ‘K’ for km/hr or ‘M’ for mph or 'm' for m/s
        '       SkyT 28-33 sky-ambient temperature, 999. for saturated hot, -999. for saturated cold, or –998. for wet
        '       AmbT 35-40 ambient temperature
        '       SenT 41-47 sensor case temperature, 999. for saturated hot, -999. for saturated cold. Neither saturated condition should ever occur.
        '       Wind 49-54 wind speed or:
        '           -1. if still heating up,
        '           -2. if wet,
        '           -3. if the A/D from the wind probe is bad (firmware <V56 only) ,
        '           -4. if the probe is not heating (a failure condition),
        '           -5. if the A/D from the wind probe is low (shorted, a failure condition) 
        '           -6. if the A/D from the wind probe is high (no probe plugged in or a failure)
        '       Hum 56-58 relative humidity in %
        '       DewPt 60-65 dew point temperature
        '       Hea 67-69 heater setting in %
        '       R 71 rain flag, =0 for dry, =1 for rain in the last minute, =2 for rain right now
        '       W 73 wet flag, =0 for dry, =1 for wet in the last minute, =2 for wet right now
        '       Since 75-79 seconds since the last valid data
        '       Now() Day's 81-92 date/time given as the VB6 Now() function result (in days) when Clarity II last wrote this file
        '       c 94 cloud condition  
        '           0 - unknown
        '           1 - clear
        '           2 - cloudy
        '           3 - very cloudy
        '       w 96 wind condition 
        '           0 - unknown
        '           1 - Calm
        '           2 - windy
        '           3 - very windy
        '       r 98 rain condition 
        '           0 - unknown
        '           1 - dry
        '           2 - wet
        '           3 - very rain
        '       d 100 daylight condition 
        '           0 - unknown
        '           1 - dark
        '           2 - light
        '           3 - very light
        '       C 102 roof close, =0 not requested, =1 if roof close was requested on this cycle
        '       A 104 alert, =0 when not alerting, =1 when alerting 
        '
        '
        '  While we are here, also append to the data log file (for plotting in Excel, whatever)

        Dim boltFile, fso
        Dim s As String
        Dim d As Date
        Dim myDay, myMonth As Integer
        
        d = Now()
        ' watch for single digit month or day
        myDay = d.Day
        If (myDay < 10) Then
            myDay = "0" & myDay
        End If
        myMonth = d.Month
        If (myMonth < 10) Then
            myMonth = "0" & myMonth
        End If

        s = d.Year.ToString & "-" & myMonth & "-" & myDay & " " & FormatDateTime(d.TimeOfDay.ToString, 4) & ":00.00 C M " & FormatNumber(degC, 1) & "   0     0       0      0   0      000 0 0 00002 000001.00000 0 0 0 0"

        fso = CreateObject("Scripting.FileSystemObject")
        Try
            boltFile = fso.OpenTextFile(txtBoltwoodPath.Text, 2, True)
            boltFile.WriteLine(s)
            boltFile.Close()
            boltFile = Nothing

        Catch ex As Exception
            LogMyMsg("Error opening Boltwood file " & txtBoltwoodPath.Text & vbCrLf & Err.Description)
        End Try

    End Sub

    Sub WriteACDataLog(degC1 As Double, degC2 As Double)
        Dim s As String
        Dim d As Date
        Dim myDay, myMonth As Integer

        If (Not cbLogExcelData.Checked) Then
            Exit Sub
        End If
        d = Now()
        ' watch for single digit month or day
        myDay = d.Day
        If (myDay < 10) Then
            myDay = "0" & myDay
        End If
        myMonth = d.Month
        If (myMonth < 10) Then
            myMonth = "0" & myMonth
        End If

        s = d.Year.ToString & "-" & myMonth & "-" & myDay & " " & FormatDateTime(d.TimeOfDay.ToString, 3) & "," & FormatNumber(degC1, 2) & "," & FormatNumber(degC2, 2)
        If (Not IsNothing(DataFile)) Then       ' dataFile is open
            DataFile.WriteLine(s)
        End If
    End Sub

    Private Sub LogMyMsg(s As String)
        txtLog.AppendText(s & vbCrLf)
    End Sub

    Private Sub VerboseMsg(s As String)
        If (ckVerbose.Checked) Then
            txtLog.AppendText(s & vbCrLf)
        End If
    End Sub


    Private Sub CommPortBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        OpenSerialPort()
    End Sub

    Private Function LabelCurrentTime() As Date
        Dim currentTime As Date
        currentTime = TimeOfDay
        lblCurrentTime.Text = currentTime.TimeOfDay.ToString
        LabelCurrentTime = currentTime
    End Function

    Sub ControlOnTime(currentTime As Date)
        ' timer callback for time control
        Dim onTime As Date
        Dim offTime As Date
        Dim onSecs As Long
        Dim offSecs As Long
        Dim curSecs As Long
        Dim normalMode As Boolean
        Dim msg As String

        If Not DateTime.TryParseExact(txtOnTime.Text, "H:mm:ss", Nothing,
                                   System.Globalization.DateTimeStyles.None, onTime) Then
            LogMyMsg("Invalid On Time format " & txtOnTime.Text)
            Exit Sub
        End If
        If Not DateTime.TryParseExact(txtOffTime.Text, "H:mm:ss", Nothing,
                                   System.Globalization.DateTimeStyles.None, offTime) Then
            LogMyMsg("Invalid Off Time format " & txtOffTime.Text)
            Exit Sub
        End If

        onSecs = Hour(onTime) * 60 + Minute(onTime)
        offSecs = Hour(offTime) * 60 + Minute(offTime)
        curSecs = Hour(currentTime) * 60 + Minute(currentTime)

        ' Potentially, we have two possibilities
        ' Normal situation, where start time < end time  (7AM to 2PM)
        ' Reverse situation, where we want to run from 2PM to 7AM
        If (onSecs < offSecs) Then
            normalMode = True
        Else
            normalMode = False
        End If

        msg = Now().ToString("MM/dd/yyyy hh:mm tt") & " no change" & onSecs & " " & curSecs & " " & offSecs
        If (((normalMode) And (curSecs <= offSecs) And (curSecs >= onSecs)) Or _
            ((Not normalMode) And (curSecs >= onSecs) And (curSecs >= offSecs))) Then
            ' needs to be on
            msg = Now().ToString("MM/dd/yyyy hh:mm tt") & " Needs on " & onSecs & " " & curSecs & " " & offSecs
            If (Not iRunning) Then
                SetACPower(True)
                msg = msg & "turned on"
                LogMyMsg(Now().ToString("MM/dd/yyyy hh:mm tt") & " Turned ON for time")
            End If
        Else
            ' needs to be off
            msg = Now().ToString("MM/dd/yyyy hh:mm tt") & " Needs off " & onSecs & " " & curSecs & " " & offSecs
            If (iRunning) Then
                SetACPower(False)
                msg = msg & "turned off"
                LogMyMsg(Now().ToString("MM/dd/yyyy hh:mm tt") & " Turned OFF for time")
            End If
        End If

        VerboseMsg(msg)

    End Sub

    Private Sub ControlOnTemp(degF As Double)
        Dim lowTemp As Double
        Dim highTemp As Double
        Dim chgStr As String
        Dim logStr As String

        If (txtLowTemp.Text = "") Then              ' I might be in the process of editing the field
            LogMyMsg("Invalid text in Lower Temp")
            Exit Sub
        End If
        If (txtHighTemp.Text = "") Then
            LogMyMsg("Invalid text in Upper Temp")
            Exit Sub
        End If

        lowTemp = CDbl(txtLowTemp.Text)
        highTemp = CDbl(txtHighTemp.Text)

        chgStr = ""
        If ((degF < lowTemp) And (iRunning = True)) Then
            SetACPower(False)
            chgStr = "  Turned off AC"
        ElseIf ((degF > highTemp) And (iRunning = False)) Then
            SetACPower(True)
            chgStr = "  Turned ON AC"
        End If

        If (chgStr <> "") Then
            logStr = Now().ToString("MM/dd/yyyy hh:mm tt") & ": " & degF & chgStr
            LogMyMsg(logStr)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim degF As Double
        Dim currentTime As Date

        ' Read temperature, then decide what to do with it
        degF = GetCurrTemp()
        currentTime = LabelCurrentTime()

        If (controlMode = MODE_MANUAL) Then
            ' do manual needs
        ElseIf (controlMode = MODE_TEMP) Then
            ' do Temperature control
            ControlOnTemp(degF)
        ElseIf (controlMode = MODE_TIME) Then
            ' do time control
            ControlOnTime(currentTime)
        End If

        ' Reset Timer interval in case we changed the option
        Timer1.Interval = CLng(txtTimerValue.Text)
    End Sub

    Private Sub EnableTempControl(onoff As Boolean)
        If onoff Then
            'enable
            controlMode = MODE_TEMP
            btnEnableTemp.BackColor = ACTIVE_COLOR
            tblTemp.BackColor = ACTIVE_TABLE_COLOR
            txtHighTemp.Enabled = True
            txtLowTemp.Enabled = True
        Else
            ' disable
            btnEnableTemp.BackColor = INACTIVE_COLOR
            tblTemp.BackColor = INACTIVE_TABLE_COLOR
            txtHighTemp.Enabled = False
            txtLowTemp.Enabled = False
        End If
    End Sub

    Private Sub EnableTimeControl(onoff As Boolean)
        If onoff Then
            'enable
            controlMode = MODE_TIME
            btnEnableTime.BackColor = ACTIVE_COLOR
            tblTime.BackColor = ACTIVE_TABLE_COLOR
            txtOnTime.Enabled = True
            txtOffTime.Enabled = True
        Else
            ' disable
            btnEnableTime.BackColor = INACTIVE_COLOR
            tblTime.BackColor = INACTIVE_TABLE_COLOR
            txtOnTime.Enabled = False
            txtOffTime.Enabled = False
        End If
    End Sub

    Private Sub EnableManualControl(onoff As Boolean)
        If onoff Then
            'enable
            controlMode = MODE_MANUAL
            btnEnableManual.BackColor = ACTIVE_COLOR
            tblManual.BackColor = ACTIVE_TABLE_COLOR
            btnTurnOff.Enabled = True
            btnTurnOn.Enabled = True
        Else
            ' disable
            btnEnableManual.BackColor = INACTIVE_COLOR
            tblManual.BackColor = INACTIVE_TABLE_COLOR
            btnTurnOff.Enabled = False
            btnTurnOn.Enabled = False
        End If
    End Sub

    Private Sub btnEnableTemp_Click(sender As Object, e As EventArgs) Handles btnEnableTemp.Click
        EnableTimeControl(False)
        EnableManualControl(False)
        EnableTempControl(True)
        Timer1_Tick(sender, e)
    End Sub

    Private Sub btnEnableTime_Click(sender As Object, e As EventArgs) Handles btnEnableTime.Click
        EnableManualControl(False)
        EnableTempControl(False)
        EnableTimeControl(True)
        Timer1_Tick(sender, e)

    End Sub

    Private Sub btnEnableManual_Click(sender As Object, e As EventArgs) Handles btnEnableManual.Click
        EnableTimeControl(False)
        EnableTempControl(False)
        EnableManualControl(True)
        Timer1_Tick(sender, e)

    End Sub

    Private Sub btnTurnOn_Click(sender As Object, e As EventArgs) Handles btnTurnOn.Click
        SetACPower(True)
        LogMyMsg(Now().ToString("MM/dd/yyyy hh:mm tt") & " Manually Turned ON")
    End Sub

    Private Sub btnTurnOff_Click(sender As Object, e As EventArgs) Handles btnTurnOff.Click
        SetACPower(False)
        LogMyMsg(Now().ToString("MM/dd/yyyy hh:mm tt") & " Manually Turned OFF")
    End Sub

    Private Sub btnOptionSave_Click(sender As Object, e As EventArgs) Handles btnOptionSave.Click
        SaveMySettings()


        ' apply changes
        OpenSerialPort()
        OpenDataLogFile()
        ' Reset Timer interval in case we changed the option
        Timer1.Interval = CLng(txtTimerValue.Text)
    End Sub

    ' routines to specify the file paths for various files (from the Options tab)
    Private Sub btnBoltwoodDialog_Click(sender As Object, e As EventArgs) Handles btnBoltwoodDialog.Click
        If (OpenBoltwoodDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            txtBoltwoodPath.Text = OpenBoltwoodDialog.FileName
        End If

    End Sub

    Private Sub btnDataDialog_Click(sender As Object, e As EventArgs) Handles btnDataDialog.Click
        If (OpenTempDataDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            txtDataPath.Text = OpenTempDataDialog.FileName
            OpenDataLogFile()
        End If

    End Sub

    Private Sub btnWebDialog_Click(sender As Object, e As EventArgs) Handles btnWebDialog.Click
        If (OpenWebDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            txtWebFile.Text = OpenWebDialog.FileName
        End If

    End Sub

    Const MAX_GRAPH_PTS = 500
    Dim timeMax As Date, timeMin As Date

    Function RandTemp(base As Double, delta As Integer) As Double
        RandTemp = base + rand.Next(delta)
    End Function

    Sub InitGraphData()
        Dim timeX As Date
        Dim dblTimeX As Double
        Dim Probe1 As Double
        Dim Probe2 As Double
        Dim ACOn As Double
        Dim timeNow As Date
        Dim timerIntervalSecs As Long
        
        Dim i As Integer
        timerIntervalSecs = CLng(txtTimerValue.Text) / 1000           ' interval in secs
        chData.ChartAreas("ChartArea1").AxisX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Minutes
        chData.ChartAreas("ChartArea2").AxisX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Minutes
        chData.ChartAreas("ChartArea1").AxisX.LabelStyle.Format = "HH:mm:ss"        ' "MM/dd/yy" & vbCrLf & "HH:mm:ss"
        chData.ChartAreas("ChartArea2").AxisX.LabelStyle.Format = "MM/dd/yy HH:mm:ss"
        chData.Series("Probe 1").Points.Dispose()           ' remove previous data
        chData.Series("Probe 2").Points.Dispose()
        chData.Series("ACOn").Points.Dispose()

        timeNow = Now()
        Dim origTimeNow As Date = timeNow
        ' change the minutes to the next larger multiple of 10.
        ' i.e, minutes = 34 means to add 6
        ' OK, now 34 means 35
        timeNow = timeNow.AddMinutes(1.0)
        timeMax = New DateTime(timeNow.Year, timeNow.Month, timeNow.Day, timeNow.Hour, timeNow.Minute, 0)
        ' Set Max for the Chart areas
        chData.ChartAreas(0).AxisX.Maximum = timeMax.ToOADate
        chData.ChartAreas(1).AxisX.Maximum = timeMax.ToOADate
        RecalculateGraphMinimum()

        For i = 0 To MAX_GRAPH_PTS - 1
            Probe1 = 75.0
            Probe2 = 76.0
            ACOn = 0.0
            timeX = origTimeNow.AddSeconds(-timerIntervalSecs * (MAX_GRAPH_PTS - i))     'DateTime.Now()
            dblTimeX = timeX.ToOADate
            chData.Series("Probe 1").Points.AddXY(dblTimeX, Probe1)
            chData.Series("Probe 1").Points(i).ToolTip = timeX.ToLongTimeString & ": Probe1= " & FormatNumber(Probe1, 2)

            chData.Series("Probe 2").Points.AddXY(dblTimeX, Probe2)
            chData.Series("Probe 2").Points(i).ToolTip = timeX.ToLongTimeString & ": Probe2= " & FormatNumber(Probe2, 2)
            chData.Series("ACOn").Points.AddXY(dblTimeX, ACOn)
        Next
    End Sub

    Sub AddToGraph(P1 As Double, P2 As Double)
        ' get the time stamp
        Dim timeX As Double = Now().ToOADate
        Dim themax As Double = timeMax.ToOADate
        If (timeX > themax) Then
            ' Need to bump axis
            While (timeX > timeMax.ToOADate)
                timeMax = timeMax.AddMinutes(1.0)
                timeMin = timeMin.AddMinutes(1.0)
            End While
            chData.ChartAreas(0).AxisX.Maximum = timeMax.ToOADate
            chData.ChartAreas(0).AxisX.Minimum = timeMin.ToOADate
            chData.ChartAreas(1).AxisX.Maximum = timeMax.ToOADate
            chData.ChartAreas(1).AxisX.Minimum = timeMin.ToOADate
            chData.ChartAreas(0).RecalculateAxesScale()
            chData.ChartAreas(1).RecalculateAxesScale()
        End If

        ' remove the first point
        For i = 0 To MAX_GRAPH_PTS - 2
            chData.Series("Probe 1").Points(i).SetValueXY(chData.Series("Probe 1").Points(i + 1).XValue, chData.Series("Probe 1").Points(i + 1).YValues(0))
            chData.Series("Probe 1").Points(i).ToolTip = chData.Series("Probe 1").Points(i + 1).ToolTip
            chData.Series("Probe 2").Points(i).SetValueXY(chData.Series("Probe 2").Points(i + 1).XValue, chData.Series("Probe 2").Points(i + 1).YValues(0))
            chData.Series("Probe 2").Points(i).ToolTip = chData.Series("Probe 2").Points(i + 1).ToolTip
            chData.Series("ACOn").Points(i).SetValueXY(chData.Series("ACOn").Points(i + 1).XValue, chData.Series("ACOn").Points(i + 1).YValues(0))
        Next i

        ' add the new points
        chData.Series("Probe 1").Points(MAX_GRAPH_PTS - 1).SetValueXY(timeX, P1)
        chData.Series("Probe 1").Points(MAX_GRAPH_PTS - 1).ToolTip = Now().ToLongTimeString & ": Probe1= " & FormatNumber(P1, 2)
        chData.Series("Probe 2").Points(MAX_GRAPH_PTS - 1).SetValueXY(timeX, P2)
        chData.Series("Probe 2").Points(MAX_GRAPH_PTS - 1).ToolTip = Now().ToLongTimeString & ": Probe2= " & FormatNumber(P2, 2)
        If (iRunning) Then
            chData.Series("ACOn").Points(MAX_GRAPH_PTS - 1).SetValueXY(timeX, 1.0)
        Else
            chData.Series("ACOn").Points(MAX_GRAPH_PTS - 1).SetValueXY(timeX, 0.0)
        End If

        chData.Series("Probe 1").BorderWidth = 1
        chData.Series("Probe 2").BorderWidth = 1
        If (controlMode = MODE_TEMP) Then
            If (opProbe2.Checked) Then
                chData.Series("Probe 2").BorderWidth = 3
            Else
                chData.Series("Probe 1").BorderWidth = 3
            End If
        End If

        chData.Refresh()
        chData.Update()
        SaveTheGraph()         ' Maybe this is causing program to become background process?
    End Sub

    ' routine to save the graph to disc for web site display
    Private Sub SaveTheGraph()
        Dim filePath As String = txtWebFile.Text
        Dim wid As Integer = Me.Width
        Dim hgt As Integer = Me.Height
        Dim bm As New Bitmap(wid, hgt)
        Dim myFmt As System.Drawing.Imaging.ImageFormat
        Dim myExt As String             ' includes the period, like .png

        ' Determine what format we will be using
        Dim myFileInfo As New FileInfo(filePath)
        myExt = myFileInfo.Extension
        If (myExt = ".png") Then
            myFmt = System.Drawing.Imaging.ImageFormat.Png
        ElseIf (myExt = ".jpg") Then
            myFmt = System.Drawing.Imaging.ImageFormat.Jpeg
        Else
            MsgBox("Unknown extension {" & myExt & "} for the Web Graph file. Creating png files by default. See the options tab to correct.", MsgBoxStyle.Information, "Problem creating Web Graph File")
            myExt = ".png"
            myFmt = System.Drawing.Imaging.ImageFormat.Png
        End If
        'LogMyMsg("Ext is {" & myExt & "} and file path is {" & filePath & "}")

        ' If the graph is not visible, save the currently active screen, make graph active, then restore original screen
        Dim activeTab As System.Windows.Forms.TabPage

        If (Not TabControl.SelectedTab.Name = "TabGraph") Then
            activeTab = TabControl.SelectedTab
            TabControl.SelectTab("TabGraph")
        Else
            activeTab = TabControl.TabPages("TabGraph")
        End If
        ' Draw the form onto the bitmap.
        Me.DrawToBitmap(bm, New Rectangle(0, 0, wid, hgt))
        If (activeTab.Name <> "TabGraph") Then
            TabControl.SelectTab(activeTab.Name)
        End If

        ' if file exists, delete it
        If (myFileInfo.Exists) Then
            myFileInfo.Delete()
        End If
        'bm.Save(filePath, myFmt)

        ' If after 7:00AM and dayfile does not exist, save the day's graph
        Dim timeNow As Date = Now().ToLocalTime

        If (timeNow.Hour >= 7) Then
            ' OK, save daily file with today's date file
            Dim yesterday As Date = Date.Today
            yesterday = yesterday.AddDays(-1)               ' subtract a day since the current graph reflects yesterday's stuff
            Dim dayFileName As String = myFileInfo.DirectoryName & "/" & myFileInfo.Name & "_" & yesterday.ToString("yyyy'-'MM'-'dd") & myFileInfo.Extension
            ' only create the daily file if it doesn't exist yet
            myFileInfo = Nothing
            myFileInfo = New FileInfo(dayFileName)
            If (Not myFileInfo.Exists) Then
                'bm.Save(dayFileName, myFmt)  ' seems to cause hang?
            End If
        End If

        myFileInfo = Nothing
        bm.Dispose()

    End Sub

    Private Sub txtTimerValue_Validated(sender As Object, e As EventArgs) Handles txtTimerValue.Validated
        ' User has changed the timer interval.
        RecalculateGraphMinimum()

        ' change the timer
        Timer1.Interval = CLng(txtTimerValue.Text)
    End Sub

    Sub RecalculateGraphMinimum()
        ' need to recalculate the chart minimum value
        Dim timerIntervalSecs As Long

        timerIntervalSecs = CLng(txtTimerValue.Text) / 1000           ' interval in secs
        Dim hourOffset As Double = -MAX_GRAPH_PTS * timerIntervalSecs / 60
        timeMin = timeMax.AddMinutes(hourOffset)
        timeMin = timeMin.AddMinutes(-1)

        ' reset the minimums
        chData.ChartAreas(0).AxisX.Minimum = timeMin.ToOADate
        chData.ChartAreas(1).AxisX.Minimum = timeMin.ToOADate
        chData.ChartAreas(0).RecalculateAxesScale()
        chData.ChartAreas(1).RecalculateAxesScale()

    End Sub

End Class
