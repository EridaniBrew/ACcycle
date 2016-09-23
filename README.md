# ACcycle
System to read temperature from an arduino and control an air conditioner using Digilogger Power Controller.

The controlling program ACCycle reads the temperature from an electronics cabinet in my observatory using an Arduino Uno connected via USB. 
This temperature is used to turn on/off an air conditioner using a Digilogger Power Controller.

The control opperates in one of 3 ways:

1) Manual. The user clicks On or Off buttons to toggle the air conditioner.

2) Time. The user specifies a start time and end time for having the air conditioner running.

3) Temperature. The user specifies an upper and lower temperature. If the temperature rises above the upper limit the AC is turned on. The AC remains on until the temperature drops below the lower limit.

ACCycle displays the temperature history on a Graph tab. This graph is saved to a png file for display on a web page.

ACCycle can also optionally generate a Boltwood file. This file is FTPd to another computer which displays the observatory temperature using WeatherDisplay.

ACCycle can also generate a csv file for import into Excel. I do not currently use this feature any more.
