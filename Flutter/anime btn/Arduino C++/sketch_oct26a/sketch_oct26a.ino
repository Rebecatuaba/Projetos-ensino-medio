#include <Servo.h> 

Servo servoSensor;
int pos = 0;

void setup() {
  // put your setup code here, to run once:
servoSensor.attach(2); 
}

void loop() {
  // put your main code here, to run repeatedly:
servoSensor.write (0);   

for(pos = 0; pos < 180; pos += 1) // Vai de 0 grau a 180 em passo de 1 grau
{
// Chama o servo1 para ir para a posição da variavel "pos"
servoSensor.write(pos);
delay(4); // Agurade 50ms para para o servo1 atingir a posição
}
for(pos = 180; pos>=1; pos-=1) // Vai de 180 graus ate 0
{
// Chama o servo1 para ir para a posição da variavel "pos"
servoSensor.write(pos);
delay(1); // Aguarda 10ms para o servo1 atingir a posição
}
}
