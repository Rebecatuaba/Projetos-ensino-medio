
//ROBO NOMEADO COMO BD-1 COM CARRINHO, AMOR e ÓDIO <3

//bibliotecas adicinadas
#include <Servo.h>
#include <AFMotor.h>

#define SERVO 6 //!@!!!!!! definir servo motor antes de usar
Servo s; //variável servo
int pos = 0; //variável posição

long Microsegundos = 0;// Variável para armazenar o valor do tempo da reflexão do som refletido pelo objeto fornecido pela biblioteca do sensor
const int pinEcho = A1; 
const int pinTrig = A0; 
float tempoEcho = 0; // Variável para armazenar o valor da distância

// Obs. Velocidade do som = 340,29 m/s = 0.00034029 m/us
const float velocidadeSom = 0.00034029; // em metros por microsegundo

//declaração dos motores
AF_DCMotor MT1(1); 
AF_DCMotor MT2(2);

void setup() {

s.attach(SERVO);
s.write(0); // Inicia motor posição zero

  MT1.setSpeed(150);
  MT2.setSpeed(150);

  pinMode(pinEcho, INPUT); // configura pino ECHO como entrada
  pinMode(pinTrig, OUTPUT); // configura pino TRIG como saída
  Serial.begin(9600);

  // Inicializa pino Trig em nível baixo
  digitalWrite(pinTrig, LOW);
}



void loop() {

   gatilhoSensor(); // envia pulso trigger (gatilho) para disparar o sensor  
  Microsegundos= pulseIn(pinEcho, HIGH); // mede o tempo de duração do sinal no pino de leitura em us
  // exibe no monitor serial
  Serial.print("Distancia em metros: ");
  Serial.println(calculaDistancia(tempoEcho), 4);
  Serial.print("Distancia em centimetros: ");
  Serial.println(calculaDistancia(tempoEcho)*100);
  Serial.println("------------------------------------");
  
  delay(2000); // aguarda dois segundos

  
  if (tempoEcho <= 40) {// Se a distância lida pelo sensor for menor ou igual que 40 centimetros
    for(pos = 0; pos < 90; pos++)
  {
    s.write(pos);
  delay(15);
  }
delay(1000);
  for(pos = 90; pos >= 0; pos--)
  {
    s.write(pos);
    delay(15);
  }

  } else { //se a distância for maior que 40 centimetros
    Andar(1);
    delay(2000);
  }

  
  }



  void Andar(int direcao) {
  if (direcao == 1) { // anda pra frente
    MT1.run(FORWARD);
    MT2.run(FORWARD);
  }

  if (direcao == 2) { // anda pra trás
    MT1.run(BACKWARD);
    MT2.run(BACKWARD);
  }

  if (direcao == 3) { // faz curva pra direita
    MT1.run(FORWARD);
    MT2.run(BACKWARD);
  }

  if (direcao == 4) { // faz curva pra esquerda
    MT1.run(BACKWARD);
    MT2.run(FORWARD);
  }

  if (direcao == 5) { // para
    MT1.run(RELEASE);
    MT2.run(RELEASE);
  }
}

// Funçao para enviar o pulso de trigger
void  gatilhoSensor(){
  // Para fazer o HC-SR04 enviar um pulso ultrassonico, nos temos
  // que enviar para o pino de trigger um sinal de nivel alto
  // com pelo menos 10us de duraçao
  digitalWrite(pinTrig, HIGH);
  delayMicroseconds(10);
  digitalWrite(pinTrig, LOW);
}

// Função para calcular a distancia em metros
float calculaDistancia(float Microsegundos){
  return((Microsegundos*velocidadeSom)/2); // velocidade do som em m/microssegundo
}
