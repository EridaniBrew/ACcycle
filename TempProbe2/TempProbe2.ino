/*
 * Based on Adafruit example for reading the TMP36 sensor.
 * I will use the 3.3 volt method for somewhat better precision
 */

/* NOTE - either all global variables are declared here, or I need to use
   a separate Variables.h header and include it in every file.
   */
#define aref_voltage 3.3 // we tie 3.3V to ARef and measure it with a multimeter!

//TMP36 Pin Variables
int sensorPin = 1; //the analog pin the TMP36's Vout (sense) pin is connected to
                        //the resolution is 10 mV / degree centigrade with a
                        //500 mV offset to allow for negative temperatures
int sensorPin2 = 2;    // the second temperature probe

int LED = 13;           // default built in LED

/*
 * setup() - this function runs once when you turn your Arduino on
 * We initialize the serial connection with the computer
 */
void setup()
{
  Serial.begin(9600);  //Start the serial connection with the computer
                       //to view the result open the serial monitor 

  // If you want to set the aref to something other than 5v
  analogReference(EXTERNAL);
  
  // initialize digital pin as output
  pinMode (LED, OUTPUT);
}


void loop()                     // run over and over again
{
  int inByte;
  
  digitalWrite (LED, HIGH);     // turn led on
  while (Serial.available() > 0)
    {
    inByte = Serial.read();
    switch (inByte)
      {
      case 'T':
      case 't':
            // handle reading temperature
            readTemperature();
            break;
      default:
            ;
      }
    }
  delay(300); 
  digitalWrite (LED, LOW);     // turn led off
  delay(700);                                     //waiting a second
}
