<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.pnlTop = New System.Windows.Forms.FlowLayoutPanel()
        Me.imOnOffLight = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDegC2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDegF2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDegC1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDegF1 = New System.Windows.Forms.Label()
        Me.lblTimeStamp = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabACControl = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblTemp = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnEnableTemp = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHighTemp = New System.Windows.Forms.TextBox()
        Me.txtLowTemp = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.tblManual = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnableManual = New System.Windows.Forms.Button()
        Me.btnTurnOn = New System.Windows.Forms.Button()
        Me.btnTurnOff = New System.Windows.Forms.Button()
        Me.tblTime = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnableTime = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOnTime = New System.Windows.Forms.TextBox()
        Me.txtOffTime = New System.Windows.Forms.TextBox()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabOptions = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opProbe2 = New System.Windows.Forms.RadioButton()
        Me.opProbe1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CommPortBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTimerValue = New System.Windows.Forms.MaskedTextBox()
        Me.btnOptionSave = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtBoltwoodPath = New System.Windows.Forms.TextBox()
        Me.btnBoltwoodDialog = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtDataPath = New System.Windows.Forms.TextBox()
        Me.btnDataDialog = New System.Windows.Forms.Button()
        Me.cbLogExcelData = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtWebFile = New System.Windows.Forms.TextBox()
        Me.btnWebDialog = New System.Windows.Forms.Button()
        Me.ckVerbose = New System.Windows.Forms.CheckBox()
        Me.cbMakeWebFile = New System.Windows.Forms.CheckBox()
        Me.TabGraph = New System.Windows.Forms.TabPage()
        Me.chData = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenBoltwoodDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OpenTempDataDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OpenWebDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnCreateImg = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        CType(Me.imOnOffLight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabACControl.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tblTemp.SuspendLayout()
        Me.tblManual.SuspendLayout()
        Me.tblTime.SuspendLayout()
        Me.TabOptions.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.TabGraph.SuspendLayout()
        CType(Me.chData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM4"
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.AutoSize = True
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.Controls.Add(Me.imOnOffLight)
        Me.pnlTop.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlTop.Location = New System.Drawing.Point(2, 2)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(543, 52)
        Me.pnlTop.TabIndex = 0
        '
        'imOnOffLight
        '
        Me.imOnOffLight.Image = Global.ACCycle.My.Resources.Resources.lightOff
        Me.imOnOffLight.InitialImage = Nothing
        Me.imOnOffLight.Location = New System.Drawing.Point(2, 2)
        Me.imOnOffLight.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.imOnOffLight.Name = "imOnOffLight"
        Me.imOnOffLight.Size = New System.Drawing.Size(43, 47)
        Me.imOnOffLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imOnOffLight.TabIndex = 17
        Me.imOnOffLight.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDegC2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDegF2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDegC1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDegF1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTimeStamp, 5, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(346, 48)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Probe 1"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(188, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 24)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "C"
        '
        'lblDegC2
        '
        Me.lblDegC2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDegC2.AutoSize = True
        Me.lblDegC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegC2.ForeColor = System.Drawing.Color.Blue
        Me.lblDegC2.Location = New System.Drawing.Point(139, 24)
        Me.lblDegC2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDegC2.Name = "lblDegC2"
        Me.lblDegC2.Size = New System.Drawing.Size(45, 24)
        Me.lblDegC2.TabIndex = 14
        Me.lblDegC2.Text = "00.0"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "F"
        '
        'lblDegF2
        '
        Me.lblDegF2.AutoSize = True
        Me.lblDegF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegF2.ForeColor = System.Drawing.Color.Blue
        Me.lblDegF2.Location = New System.Drawing.Point(64, 24)
        Me.lblDegF2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDegF2.Name = "lblDegF2"
        Me.lblDegF2.Size = New System.Drawing.Size(45, 24)
        Me.lblDegF2.TabIndex = 12
        Me.lblDegF2.Text = "00.0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Probe 2"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(188, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "C"
        '
        'lblDegC1
        '
        Me.lblDegC1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDegC1.AutoSize = True
        Me.lblDegC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegC1.ForeColor = System.Drawing.Color.Crimson
        Me.lblDegC1.Location = New System.Drawing.Point(139, 0)
        Me.lblDegC1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDegC1.Name = "lblDegC1"
        Me.lblDegC1.Size = New System.Drawing.Size(45, 24)
        Me.lblDegC1.TabIndex = 9
        Me.lblDegC1.Text = "00.0"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "F"
        '
        'lblDegF1
        '
        Me.lblDegF1.AutoSize = True
        Me.lblDegF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegF1.ForeColor = System.Drawing.Color.Crimson
        Me.lblDegF1.Location = New System.Drawing.Point(64, 0)
        Me.lblDegF1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDegF1.Name = "lblDegF1"
        Me.lblDegF1.Size = New System.Drawing.Size(45, 24)
        Me.lblDegF1.TabIndex = 7
        Me.lblDegF1.Text = "00.0"
        '
        'lblTimeStamp
        '
        Me.lblTimeStamp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeStamp.AutoSize = True
        Me.lblTimeStamp.Location = New System.Drawing.Point(215, 0)
        Me.lblTimeStamp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeStamp.Name = "lblTimeStamp"
        Me.lblTimeStamp.Size = New System.Drawing.Size(129, 13)
        Me.lblTimeStamp.TabIndex = 19
        Me.lblTimeStamp.Text = "As of 4/23/2015 1:15 AM"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TabControl, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.pnlTop, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(547, 361)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabACControl)
        Me.TabControl.Controls.Add(Me.TabOptions)
        Me.TabControl.Controls.Add(Me.TabGraph)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(2, 58)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(543, 301)
        Me.TabControl.TabIndex = 5
        '
        'TabACControl
        '
        Me.TabACControl.Controls.Add(Me.TableLayoutPanel4)
        Me.TabACControl.Location = New System.Drawing.Point(4, 22)
        Me.TabACControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabACControl.Name = "TabACControl"
        Me.TabACControl.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabACControl.Size = New System.Drawing.Size(535, 275)
        Me.TabACControl.TabIndex = 0
        Me.TabACControl.Text = "AC Control"
        Me.TabACControl.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.Controls.Add(Me.tblTemp, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtLog, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.tblManual, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.tblTime, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(531, 271)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'tblTemp
        '
        Me.tblTemp.BackColor = System.Drawing.Color.Transparent
        Me.tblTemp.ColumnCount = 2
        Me.tblTemp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTemp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTemp.Controls.Add(Me.Label13, 0, 2)
        Me.tblTemp.Controls.Add(Me.btnEnableTemp, 0, 0)
        Me.tblTemp.Controls.Add(Me.Label12, 0, 1)
        Me.tblTemp.Controls.Add(Me.txtHighTemp, 1, 1)
        Me.tblTemp.Controls.Add(Me.txtLowTemp, 1, 2)
        Me.tblTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTemp.Location = New System.Drawing.Point(2, 2)
        Me.tblTemp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblTemp.Name = "tblTemp"
        Me.tblTemp.RowCount = 3
        Me.tblTemp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTemp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblTemp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTemp.Size = New System.Drawing.Size(172, 94)
        Me.tblTemp.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 68)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 26)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Lower Temp (stops cooling)"
        '
        'btnEnableTemp
        '
        Me.btnEnableTemp.AutoSize = True
        Me.tblTemp.SetColumnSpan(Me.btnEnableTemp, 2)
        Me.btnEnableTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEnableTemp.Location = New System.Drawing.Point(2, 2)
        Me.btnEnableTemp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnableTemp.Name = "btnEnableTemp"
        Me.btnEnableTemp.Size = New System.Drawing.Size(168, 28)
        Me.btnEnableTemp.TabIndex = 1
        Me.btnEnableTemp.Text = "Temperature"
        Me.btnEnableTemp.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(2, 35)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 26)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Upper Temp (starts cooling)"
        '
        'txtHighTemp
        '
        Me.txtHighTemp.Location = New System.Drawing.Point(88, 34)
        Me.txtHighTemp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHighTemp.Name = "txtHighTemp"
        Me.txtHighTemp.Size = New System.Drawing.Size(72, 20)
        Me.txtHighTemp.TabIndex = 12
        Me.txtHighTemp.Text = "87"
        '
        'txtLowTemp
        '
        Me.txtLowTemp.Location = New System.Drawing.Point(88, 63)
        Me.txtLowTemp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLowTemp.Name = "txtLowTemp"
        Me.txtLowTemp.Size = New System.Drawing.Size(72, 20)
        Me.txtLowTemp.TabIndex = 13
        Me.txtLowTemp.Text = "85"
        '
        'txtLog
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.txtLog, 3)
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Location = New System.Drawing.Point(2, 100)
        Me.txtLog.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(527, 171)
        Me.txtLog.TabIndex = 3
        '
        'tblManual
        '
        Me.tblManual.BackColor = System.Drawing.Color.Transparent
        Me.tblManual.ColumnCount = 1
        Me.tblManual.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblManual.Controls.Add(Me.btnEnableManual, 0, 0)
        Me.tblManual.Controls.Add(Me.btnTurnOn, 0, 1)
        Me.tblManual.Controls.Add(Me.btnTurnOff, 0, 2)
        Me.tblManual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblManual.Location = New System.Drawing.Point(355, 2)
        Me.tblManual.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblManual.Name = "tblManual"
        Me.tblManual.RowCount = 3
        Me.tblManual.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblManual.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblManual.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblManual.Size = New System.Drawing.Size(174, 94)
        Me.tblManual.TabIndex = 7
        '
        'btnEnableManual
        '
        Me.btnEnableManual.AutoSize = True
        Me.tblManual.SetColumnSpan(Me.btnEnableManual, 2)
        Me.btnEnableManual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEnableManual.Location = New System.Drawing.Point(2, 2)
        Me.btnEnableManual.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnableManual.Name = "btnEnableManual"
        Me.btnEnableManual.Size = New System.Drawing.Size(170, 26)
        Me.btnEnableManual.TabIndex = 2
        Me.btnEnableManual.Text = "Manual"
        Me.btnEnableManual.UseVisualStyleBackColor = True
        '
        'btnTurnOn
        '
        Me.btnTurnOn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTurnOn.AutoSize = True
        Me.btnTurnOn.Location = New System.Drawing.Point(2, 32)
        Me.btnTurnOn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTurnOn.Name = "btnTurnOn"
        Me.btnTurnOn.Size = New System.Drawing.Size(73, 26)
        Me.btnTurnOn.TabIndex = 3
        Me.btnTurnOn.Text = "Turn On AC"
        Me.btnTurnOn.UseVisualStyleBackColor = True
        '
        'btnTurnOff
        '
        Me.btnTurnOff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTurnOff.AutoSize = True
        Me.btnTurnOff.Location = New System.Drawing.Point(2, 62)
        Me.btnTurnOff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTurnOff.Name = "btnTurnOff"
        Me.btnTurnOff.Size = New System.Drawing.Size(73, 30)
        Me.btnTurnOff.TabIndex = 4
        Me.btnTurnOff.Text = "Turn Off AC"
        Me.btnTurnOff.UseVisualStyleBackColor = True
        '
        'tblTime
        '
        Me.tblTime.BackColor = System.Drawing.Color.Transparent
        Me.tblTime.ColumnCount = 2
        Me.tblTime.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTime.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTime.Controls.Add(Me.btnEnableTime, 0, 0)
        Me.tblTime.Controls.Add(Me.Label6, 0, 1)
        Me.tblTime.Controls.Add(Me.Label11, 0, 2)
        Me.tblTime.Controls.Add(Me.txtOnTime, 1, 1)
        Me.tblTime.Controls.Add(Me.txtOffTime, 1, 2)
        Me.tblTime.Controls.Add(Me.lblCurrentTime, 1, 3)
        Me.tblTime.Controls.Add(Me.Label9, 0, 3)
        Me.tblTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTime.Location = New System.Drawing.Point(178, 2)
        Me.tblTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblTime.Name = "tblTime"
        Me.tblTime.RowCount = 4
        Me.tblTime.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblTime.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblTime.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblTime.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblTime.Size = New System.Drawing.Size(173, 94)
        Me.tblTime.TabIndex = 8
        '
        'btnEnableTime
        '
        Me.btnEnableTime.AutoSize = True
        Me.tblTime.SetColumnSpan(Me.btnEnableTime, 2)
        Me.btnEnableTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEnableTime.Location = New System.Drawing.Point(2, 2)
        Me.btnEnableTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnableTime.Name = "btnEnableTime"
        Me.btnEnableTime.Size = New System.Drawing.Size(169, 23)
        Me.btnEnableTime.TabIndex = 0
        Me.btnEnableTime.Text = "Time"
        Me.btnEnableTime.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 38)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Turn On Time"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 62)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Turn Off Time"
        '
        'txtOnTime
        '
        Me.txtOnTime.Location = New System.Drawing.Point(88, 29)
        Me.txtOnTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOnTime.Name = "txtOnTime"
        Me.txtOnTime.Size = New System.Drawing.Size(72, 20)
        Me.txtOnTime.TabIndex = 11
        Me.txtOnTime.Text = "10:00:00"
        '
        'txtOffTime
        '
        Me.txtOffTime.Location = New System.Drawing.Point(88, 53)
        Me.txtOffTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOffTime.Name = "txtOffTime"
        Me.txtOffTime.Size = New System.Drawing.Size(72, 20)
        Me.txtOffTime.TabIndex = 12
        Me.txtOffTime.Text = "22:00:00"
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(88, 81)
        Me.lblCurrentTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(68, 13)
        Me.lblCurrentTime.TabIndex = 10
        Me.lblCurrentTime.Text = "00:00:00 AM"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 81)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Current Time"
        '
        'TabOptions
        '
        Me.TabOptions.Controls.Add(Me.TableLayoutPanel6)
        Me.TabOptions.Location = New System.Drawing.Point(4, 22)
        Me.TabOptions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabOptions.Name = "TabOptions"
        Me.TabOptions.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabOptions.Size = New System.Drawing.Size(535, 275)
        Me.TabOptions.TabIndex = 1
        Me.TabOptions.Text = "Options"
        Me.TabOptions.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSize = True
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox1, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.CommPortBox, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txtTimerValue, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.btnOptionSave, 1, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.Label14, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label15, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.FlowLayoutPanel1, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.FlowLayoutPanel2, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.cbLogExcelData, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.FlowLayoutPanel3, 1, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.ckVerbose, 1, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.cbMakeWebFile, 0, 5)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 10)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 9
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(505, 332)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opProbe2)
        Me.GroupBox1.Controls.Add(Me.opProbe1)
        Me.GroupBox1.Location = New System.Drawing.Point(254, 51)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(94, 65)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Probe Number"
        '
        'opProbe2
        '
        Me.opProbe2.AutoSize = True
        Me.opProbe2.Location = New System.Drawing.Point(11, 40)
        Me.opProbe2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.opProbe2.Name = "opProbe2"
        Me.opProbe2.Size = New System.Drawing.Size(62, 17)
        Me.opProbe2.TabIndex = 1
        Me.opProbe2.TabStop = True
        Me.opProbe2.Text = "Probe 2"
        Me.opProbe2.UseVisualStyleBackColor = True
        '
        'opProbe1
        '
        Me.opProbe1.AutoSize = True
        Me.opProbe1.Location = New System.Drawing.Point(11, 18)
        Me.opProbe1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.opProbe1.Name = "opProbe1"
        Me.opProbe1.Size = New System.Drawing.Size(62, 17)
        Me.opProbe1.TabIndex = 0
        Me.opProbe1.TabStop = True
        Me.opProbe1.Text = "Probe 1"
        Me.opProbe1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Comm Port"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CommPortBox
        '
        Me.CommPortBox.FormattingEnabled = True
        Me.CommPortBox.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15"})
        Me.CommPortBox.Location = New System.Drawing.Point(254, 2)
        Me.CommPortBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CommPortBox.Name = "CommPortBox"
        Me.CommPortBox.Size = New System.Drawing.Size(68, 21)
        Me.CommPortBox.TabIndex = 5
        Me.CommPortBox.Text = "COM4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sample Time (msec)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTimerValue
        '
        Me.txtTimerValue.Location = New System.Drawing.Point(254, 27)
        Me.txtTimerValue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTimerValue.Mask = "000000"
        Me.txtTimerValue.Name = "txtTimerValue"
        Me.txtTimerValue.Size = New System.Drawing.Size(68, 20)
        Me.txtTimerValue.TabIndex = 7
        Me.txtTimerValue.Text = "2000"
        '
        'btnOptionSave
        '
        Me.btnOptionSave.AutoSize = True
        Me.btnOptionSave.Location = New System.Drawing.Point(254, 235)
        Me.btnOptionSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOptionSave.Name = "btnOptionSave"
        Me.btnOptionSave.Size = New System.Drawing.Size(57, 23)
        Me.btnOptionSave.TabIndex = 8
        Me.btnOptionSave.Text = "Apply"
        Me.btnOptionSave.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(2, 49)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Control Temperature"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(2, 118)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 31)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Boltwood File (for Weather Display)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.txtBoltwoodPath)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBoltwoodDialog)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(254, 120)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(249, 27)
        Me.FlowLayoutPanel1.TabIndex = 13
        '
        'txtBoltwoodPath
        '
        Me.txtBoltwoodPath.Location = New System.Drawing.Point(2, 2)
        Me.txtBoltwoodPath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBoltwoodPath.Name = "txtBoltwoodPath"
        Me.txtBoltwoodPath.Size = New System.Drawing.Size(142, 20)
        Me.txtBoltwoodPath.TabIndex = 0
        '
        'btnBoltwoodDialog
        '
        Me.btnBoltwoodDialog.AutoSize = True
        Me.btnBoltwoodDialog.Location = New System.Drawing.Point(148, 2)
        Me.btnBoltwoodDialog.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBoltwoodDialog.Name = "btnBoltwoodDialog"
        Me.btnBoltwoodDialog.Size = New System.Drawing.Size(26, 23)
        Me.btnBoltwoodDialog.TabIndex = 1
        Me.btnBoltwoodDialog.Text = "..."
        Me.btnBoltwoodDialog.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.txtDataPath)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnDataDialog)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(254, 151)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(249, 27)
        Me.FlowLayoutPanel2.TabIndex = 14
        '
        'txtDataPath
        '
        Me.txtDataPath.Location = New System.Drawing.Point(2, 2)
        Me.txtDataPath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDataPath.Name = "txtDataPath"
        Me.txtDataPath.Size = New System.Drawing.Size(142, 20)
        Me.txtDataPath.TabIndex = 1
        '
        'btnDataDialog
        '
        Me.btnDataDialog.AutoSize = True
        Me.btnDataDialog.Location = New System.Drawing.Point(148, 2)
        Me.btnDataDialog.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDataDialog.Name = "btnDataDialog"
        Me.btnDataDialog.Size = New System.Drawing.Size(26, 23)
        Me.btnDataDialog.TabIndex = 2
        Me.btnDataDialog.Text = "..."
        Me.btnDataDialog.UseVisualStyleBackColor = True
        '
        'cbLogExcelData
        '
        Me.cbLogExcelData.AutoSize = True
        Me.cbLogExcelData.Location = New System.Drawing.Point(2, 151)
        Me.cbLogExcelData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbLogExcelData.Name = "cbLogExcelData"
        Me.cbLogExcelData.Size = New System.Drawing.Size(146, 17)
        Me.cbLogExcelData.TabIndex = 15
        Me.cbLogExcelData.Text = "Log Graph Data for Excel"
        Me.cbLogExcelData.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.Controls.Add(Me.txtWebFile)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnWebDialog)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnCreateImg)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(254, 182)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(249, 27)
        Me.FlowLayoutPanel3.TabIndex = 18
        '
        'txtWebFile
        '
        Me.txtWebFile.Location = New System.Drawing.Point(2, 2)
        Me.txtWebFile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWebFile.Name = "txtWebFile"
        Me.txtWebFile.Size = New System.Drawing.Size(142, 20)
        Me.txtWebFile.TabIndex = 1
        Me.txtWebFile.Text = "ACcycle_"
        '
        'btnWebDialog
        '
        Me.btnWebDialog.AutoSize = True
        Me.btnWebDialog.Location = New System.Drawing.Point(148, 2)
        Me.btnWebDialog.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnWebDialog.Name = "btnWebDialog"
        Me.btnWebDialog.Size = New System.Drawing.Size(26, 23)
        Me.btnWebDialog.TabIndex = 2
        Me.btnWebDialog.Text = "..."
        Me.btnWebDialog.UseVisualStyleBackColor = True
        '
        'ckVerbose
        '
        Me.ckVerbose.AutoSize = True
        Me.ckVerbose.Location = New System.Drawing.Point(254, 214)
        Me.ckVerbose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ckVerbose.Name = "ckVerbose"
        Me.ckVerbose.Size = New System.Drawing.Size(106, 17)
        Me.ckVerbose.TabIndex = 10
        Me.ckVerbose.Text = "Verbose Logging"
        Me.ckVerbose.UseVisualStyleBackColor = True
        '
        'cbMakeWebFile
        '
        Me.cbMakeWebFile.AutoSize = True
        Me.cbMakeWebFile.Location = New System.Drawing.Point(2, 182)
        Me.cbMakeWebFile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMakeWebFile.Name = "cbMakeWebFile"
        Me.cbMakeWebFile.Size = New System.Drawing.Size(182, 17)
        Me.cbMakeWebFile.TabIndex = 19
        Me.cbMakeWebFile.Text = "Graph Image (for Web Page use)"
        Me.cbMakeWebFile.UseVisualStyleBackColor = True
        '
        'TabGraph
        '
        Me.TabGraph.Controls.Add(Me.chData)
        Me.TabGraph.Location = New System.Drawing.Point(4, 22)
        Me.TabGraph.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabGraph.Name = "TabGraph"
        Me.TabGraph.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabGraph.Size = New System.Drawing.Size(534, 273)
        Me.TabGraph.TabIndex = 2
        Me.TabGraph.Text = "Graph"
        Me.TabGraph.UseVisualStyleBackColor = True
        '
        'chData
        '
        ChartArea1.AxisY.IsStartedFromZero = False
        ChartArea1.CursorX.IsUserEnabled = True
        ChartArea1.CursorX.IsUserSelectionEnabled = True
        ChartArea1.Name = "ChartArea1"
        ChartArea1.Position.Auto = False
        ChartArea1.Position.Height = 80.0!
        ChartArea1.Position.Width = 94.0!
        ChartArea1.Position.X = 3.0!
        ChartArea1.Position.Y = 10.0!
        ChartArea2.AlignWithChartArea = "ChartArea1"
        ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisY.Maximum = 1.0R
        ChartArea2.AxisY.Minimum = 0R
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea2"
        ChartArea2.Position.Auto = False
        ChartArea2.Position.Height = 5.0!
        ChartArea2.Position.Width = 94.0!
        ChartArea2.Position.X = 3.0!
        ChartArea2.Position.Y = 95.0!
        Me.chData.ChartAreas.Add(ChartArea1)
        Me.chData.ChartAreas.Add(ChartArea2)
        Me.chData.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.chData.Legends.Add(Legend1)
        Me.chData.Location = New System.Drawing.Point(2, 2)
        Me.chData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chData.Name = "chData"
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Red
        Series1.LabelFormat = "MM/DD/YY HH:mm:ss"
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Transparent
        Series1.Name = "Probe 1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.DodgerBlue
        Series2.LabelFormat = "MM/DD/YY HH:mm:ss"
        Series2.Legend = "Legend1"
        Series2.Name = "Probe 2"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Series3.BorderWidth = 5
        Series3.ChartArea = "ChartArea2"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series3.IsVisibleInLegend = False
        Series3.LabelFormat = "MM/DD/YY HH:mm:ss"
        Series3.Legend = "Legend1"
        Series3.Name = "ACOn"
        Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Me.chData.Series.Add(Series1)
        Me.chData.Series.Add(Series2)
        Me.chData.Series.Add(Series3)
        Me.chData.Size = New System.Drawing.Size(530, 269)
        Me.chData.TabIndex = 2
        Me.chData.Text = "Chart1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'OpenBoltwoodDialog
        '
        Me.OpenBoltwoodDialog.DefaultExt = "txt"
        Me.OpenBoltwoodDialog.FileName = "ClarityII_fmt.txt"
        '
        'OpenTempDataDialog
        '
        Me.OpenTempDataDialog.DefaultExt = "txt"
        Me.OpenTempDataDialog.FileName = "AcCycleData.txt"
        '
        'OpenWebDialog
        '
        Me.OpenWebDialog.CheckFileExists = False
        Me.OpenWebDialog.DefaultExt = "png"
        Me.OpenWebDialog.FileName = "ACcycle.png"
        Me.OpenWebDialog.InitialDirectory = "C:\Users\Public\Documents"
        Me.OpenWebDialog.Title = "Select Web Graph File name"
        '
        'btnCreateImg
        '
        Me.btnCreateImg.AutoSize = True
        Me.btnCreateImg.Location = New System.Drawing.Point(178, 2)
        Me.btnCreateImg.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCreateImg.Name = "btnCreateImg"
        Me.btnCreateImg.Size = New System.Drawing.Size(68, 23)
        Me.btnCreateImg.TabIndex = 9
        Me.btnCreateImg.Text = "Create Img"
        Me.btnCreateImg.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(547, 361)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Air Conditioning Control"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.imOnOffLight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabACControl.ResumeLayout(False)
        Me.TabACControl.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.tblTemp.ResumeLayout(False)
        Me.tblTemp.PerformLayout()
        Me.tblManual.ResumeLayout(False)
        Me.tblManual.PerformLayout()
        Me.tblTime.ResumeLayout(False)
        Me.tblTime.PerformLayout()
        Me.TabOptions.ResumeLayout(False)
        Me.TabOptions.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.TabGraph.ResumeLayout(False)
        CType(Me.chData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents pnlTop As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabACControl As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblTemp As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnEnableManual As System.Windows.Forms.Button
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents btnEnableTime As System.Windows.Forms.Button
    Friend WithEvents btnEnableTemp As System.Windows.Forms.Button
    Friend WithEvents TabOptions As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CommPortBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTimerValue As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnOptionSave As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblDegC2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDegF2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDegC1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDegF1 As System.Windows.Forms.Label
    Friend WithEvents tblManual As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnTurnOn As System.Windows.Forms.Button
    Friend WithEvents btnTurnOff As System.Windows.Forms.Button
    Friend WithEvents tblTime As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtHighTemp As System.Windows.Forms.TextBox
    Friend WithEvents txtLowTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents txtOnTime As System.Windows.Forms.TextBox
    Friend WithEvents txtOffTime As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents imOnOffLight As System.Windows.Forms.PictureBox
    Friend WithEvents ckVerbose As System.Windows.Forms.CheckBox
    Friend WithEvents opProbe2 As System.Windows.Forms.RadioButton
    Friend WithEvents opProbe1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtBoltwoodPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBoltwoodDialog As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtDataPath As System.Windows.Forms.TextBox
    Friend WithEvents btnDataDialog As System.Windows.Forms.Button
    Friend WithEvents OpenBoltwoodDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenTempDataDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabGraph As System.Windows.Forms.TabPage
    Friend WithEvents chData As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cbLogExcelData As System.Windows.Forms.CheckBox
    Friend WithEvents lblTimeStamp As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtWebFile As System.Windows.Forms.TextBox
    Friend WithEvents btnWebDialog As System.Windows.Forms.Button
    Friend WithEvents cbMakeWebFile As System.Windows.Forms.CheckBox
    Friend WithEvents OpenWebDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCreateImg As Button
End Class
