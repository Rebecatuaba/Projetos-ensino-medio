#include <Servo.h>

//servos
Servo servo1;
Servo servo2;
Servo servo3;
Servo servo4;

//joy esquerdo
int eixo_X= A2; 
int eixo_Y = A3; 
int btn1 = 3; 
//direito
int eixoX= A0; 
int eixoY = A1; 
int btn2 = 2; 

//valor
int vdx;
int vdy;
int vex;
int vey;


void setup() {
  pinMode (btn1, INPUT_PULLUP);
  pinMode (btn2, INPUT_PULLUP);

  servo1.attach(36);//base
  servo2.attach(32);//altura
  servo3.attach(38);//angulo
  servo4.attach(34);//garra

 Serial.begin (9600); //INICIALIZA O MONITOR SERIAL
  
}

void loop() {

if(digitalRead (btn2=1)){
  //base
  vex=analogRead(eixo_X);
  vex=map(vex,0,1024,0,180);
  servo1.write(vex);
  delay(500);
  //altura
  vey=analogRead(eixo_Y);
  vey=map(vey,0,1024,180,0);
  servo2.write(vey);
  delay(500);
  //angulo
  vdy=analogRead(eixoY);
  vdy=map(vdy,0,1024,180,0);
  servo3.write(vdy);
  delay(500);
  //garra
  vdx=analogRead(eixoX);
  vdx=map(vdx,0,1024,0,90);
  servo4.write(vdx);
  delay(500);

 }







 
}
