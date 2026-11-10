#include <Servo.h>

//servos
Servo servo1;  
Servo servo2; 
Servo servo3; 
Servo servo4; 

//potenciometros
int po1 = A0;  
int po2 = A1;  
int po3 = A2;  
int po4 = A3;

//valores
int v1;
int v2;
int v3;
int v4;


void setup() {
  servo1.attach(13);//altura
  servo2.attach(11);//angulo
  servo3.attach(10);//garra
  servo4.attach(12);//base

}

void loop() {

  v1 = analogRead(po1); 
  v1 = map(v1, 0, 1023, 0, 140); 
  servo1.write(v1); 
  delay(15); 

  v2 = analogRead(po2); 
  v2 = map(v2, 0, 1023, 0, 140); 
  servo2.write(v2); 
  delay(15); 

  v3 = analogRead(po3); 
  v3 = map(v3, 0, 1023, 0, 180); 
  servo3.write(v3); 
  delay(15);

  v4 = analogRead(po4); 
  v4 = map(v4, 0, 1023, 0, 180); 
  servo4.write(v4); 
  delay(15);

}
