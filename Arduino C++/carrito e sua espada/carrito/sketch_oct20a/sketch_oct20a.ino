#include <Servo.h>     
//Definindo os pinos
#define trigPin A5     
#define echoPin A4     
// motor um            
#define MT1 A1
// motor dois          
#define MT2 A2   
Servo s;
int pos = 0;
Servo servoSensor;


// void procurar       
int Procurar (void) {
float duracao = 0.0;              
float CM = 0.0;                  
digitalWrite(trigPin, LOW);     
delayMicroseconds(2);
digitalWrite(trigPin, HIGH);      
delayMicroseconds(10);
digitalWrite(trigPin, LOW);      
duracao = pulseIn(echoPin, HIGH); 
CM = (duracao / 58.8);            
Serial.print("Distancia em CM: ");
Serial.println(CM);              
return CM;                       
}

//Variaveis
int DistanciaDireita, DistanciaEsquerda;  
float Distancia = 0.00;                  

int velocidadeMotorUm = 255;
int velocidadeMotorDois = 255;

void setup() {
Serial.begin(9600); 
servoSensor.attach(6);
s.attach(2); /////
pinMode(11, OUTPUT);
pinMode(12, OUTPUT);
pinMode(13, OUTPUT);
pinMode(10, OUTPUT);
pinMode(MT1, OUTPUT);//Motor1
pinMode(MT2, OUTPUT);//Motor2
pinMode(trigPin, OUTPUT);     
pinMode(echoPin, INPUT);      
}

void loop() {
 Distancia = Procurar ();
             
if (Distancia < 20) {                   
direcao (); 
espada();                         
}
else if (Distancia >= 20)  {              
Frente ();                            
}
  } 

void espada(){
  
s.write (0);   
for(pos = 0; pos < 120; pos += 1) 
{

s.write(pos);
delay(2); 
}
for(pos = 120; pos>=1; pos-=1) 
{

s.write(pos);
delay(1); 
}
}

void direcao () {        
Parar ();                                      
ParaTras ();                                     
Parar ();                                    
servoSensor.write (180);                       
delay (100);              
DistanciaEsquerda = Procurar ();                 
delay (500);               
servoSensor.write (0);                         
delay (500);               
DistanciaDireita = Procurar ();     
delay (500);               
servoSensor.write (90);               
delay (500);              
CompareDistance ();                        
}

void CompareDistance () {                   
if (DistanciaDireita > DistanciaEsquerda) {      
Vireadireita ();                              
}
else if (DistanciaEsquerda > DistanciaDireita) {  
VireaEsquerda ();                              
}
else {                                          
Retorne ();                                 
}
}

void Parar()
{
Serial.println("Robô: Parar ");
digitalWrite(11, LOW);                         
digitalWrite(10, LOW);
digitalWrite(12, LOW);
digitalWrite(13, LOW);
delay(100);                                     
}
void Frente()
{
Serial.println("Robô: Frente ");
digitalWrite(11, HIGH);                         
digitalWrite(10, LOW);
digitalWrite(12, HIGH);
digitalWrite(13, LOW);
analogWrite(MT1, velocidadeMotorUm);             
analogWrite(MT2, velocidadeMotorDois);                                 
}

void ParaTras()
{
Serial.println("Robô: Ré ");
digitalWrite(11, LOW);                       
digitalWrite(10, HIGH);
digitalWrite(12, LOW);
digitalWrite(13, HIGH);
delay(300);                                  
analogWrite(MT1, velocidadeMotorUm);           
analogWrite(MT2, velocidadeMotorDois);                       
}

void Vireadireita()
{
Serial.println("Robô: Direita ");
digitalWrite(11, LOW);                       
digitalWrite(10, HIGH);
digitalWrite(12, HIGH);
digitalWrite(13, LOW);
delay(200);                                
analogWrite(MT1, velocidadeMotorUm);       
analogWrite(MT2, velocidadeMotorDois);                           
}

void VireaEsquerda()
{
Serial.println("Robô: Esquerda ");                
digitalWrite(11, HIGH);                     
digitalWrite(10, LOW);
digitalWrite(12, HIGH);
digitalWrite(13, LOW);
delay(200);                                  
analogWrite(MT1, velocidadeMotorUm);        
analogWrite(MT2, velocidadeMotorDois);                            
}

void Retorne () {    
Serial.println("Robô: Girar ");      
digitalWrite(11, HIGH);                     
digitalWrite(10, LOW);
digitalWrite(12, HIGH);
digitalWrite(13, LOW);
delay (400);                                 
analogWrite(MT1, velocidadeMotorUm);       
analogWrite(MT2, velocidadeMotorDois);                                
}
