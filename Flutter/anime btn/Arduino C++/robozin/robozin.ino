#include <SoftwareSerial.h>

#define MT1_1 2
#define MT1_2 3
#define MT2_1 4
#define MT2_2 5

SoftwareSerial serial1(10,11);  // RX, TX

void setup() {
  pinMode(MT1_1, OUTPUT);
  pinMode(MT1_2, OUTPUT);
  pinMode(MT2_2, OUTPUT);
  Serial.begin(9600);
  serial1.begin(9600);
}

void loop() {
  if(serial1.available())
  {
    switch(serial1.read())
    {
      case 'P':
      digitalWrite(MT1_1, LOW);
      digitalWrite(MT1_2, LOW);
      digitalWrite(MT2_1, LOW);
      digitalWrite(MT2_2, LOW);
      Serial.println("PARADO");
      break;
      
      case 'D':
      digitalWrite(MT1_1, HIGH);
      digitalWrite(MT1_2, LOW);
      digitalWrite(MT2_1, LOW);
      digitalWrite(MT2_2, HIGH);
      Serial.println("DIREITA");
      break;

      case 'T':
      digitalWrite(MT1_1, LOW);
      digitalWrite(MT1_2, HIGH);
      digitalWrite(MT2_1, LOW);
      digitalWrite(MT2_2, HIGH);
      Serial.println("RÉ");
      break;

      case 'F':
      digitalWrite(MT1_1, HIGH);
      digitalWrite(MT1_2, LOW);
      digitalWrite(MT2_1, HIGH);
      digitalWrite(MT2_2, LOW);
      Serial.println("FRENTE");
      break;

      case 'E':
      digitalWrite(MT1_1, LOW);
      digitalWrite(MT1_2, HIGH);
      digitalWrite(MT2_1, HIGH);
      digitalWrite(MT2_2, LOW);
      Serial.println("ESQUERDA");
      break;
       
    }
      
    }
  }
