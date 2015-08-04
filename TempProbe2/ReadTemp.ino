
void readTemperature()
{
 //getting the voltage reading from the temperature sensor
 int reading = analogRead(sensorPin);  
 int reading2 = analogRead(sensorPin2);  
 
 // converting that reading to voltage. Use 5 volts standard, for 3.3v arduino use 3.3
 // Note - potentially, the two sensors can interfere with each other in the AtoD. 
 // To avoid this, take two readings and discard the first.
 float voltage = (reading * aref_voltage) / 1024.0;
 voltage = (reading * aref_voltage) / 1024.0;
 float voltage2 = (reading2 * aref_voltage) / 1024.0;
 voltage2 = (reading2 * aref_voltage) / 1024.0;
 
 // convert voltage to temperature degC
 float temperatureC = (voltage - 0.5) * 100 ;  //converting from 10 mv per degree wit 500 mV offset
 float temperatureC2 = (voltage2 - 0.5) * 100 ;  //converting from 10 mv per degree wit 500 mV offset
                                               //to degrees ((voltage - 500mV) times 100)
 // convert to Fahrenheit
 float temperatureF = (temperatureC * 9.0 / 5.0) + 32.0;
 float temperatureF2 = (temperatureC2 * 9.0 / 5.0) + 32.0;
 Serial.print(temperatureF); Serial.print(" "); Serial.print(temperatureF2); Serial.print(" F ");
 Serial.print(temperatureC); Serial.print(" "); Serial.print(temperatureC2); Serial.print(" C ");
 Serial.print(voltage); Serial.print(" "); Serial.print(voltage2); Serial.println(" V");
}

