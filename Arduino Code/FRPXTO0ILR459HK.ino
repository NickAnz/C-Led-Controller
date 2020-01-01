
#include <ESP8266WiFi.h>
#include "stdlib.h"



// Red, green, and blue pins for PWM control
const int redPin = 15;     // 13 corresponds to GPIO13
const int greenPin = 12;   // 12 corresponds to GPIO12
const int bluePin = 14;    // 14 corresponds to GPIO14


int redValue = 0;
int greenValue =0;
int blueValue =0;


void setup() {
  Serial.begin(115200);
  
  // configure LED PWM resolution/range and set pins to LOW
  analogWrite(redPin, 0);
  analogWrite(greenPin, 0);
  analogWrite(bluePin, 0);

 
}

void loop(){

  if (Serial.available() > 0) {
    if (Serial.read() == 'R')
    {
      redValue = Serial.parseInt();
    Serial.println(redValue);
    
    greenValue = Serial.parseInt();
    Serial.println(greenValue);
    
    blueValue = Serial.parseInt();
    Serial.println(blueValue);
    }
    

    analogWrite(redPin,redValue);
    analogWrite(greenPin,greenValue);
    analogWrite(bluePin,blueValue);
   
    
  }

}
    
