//VERMELHO
//int r1 = A0, r2 = A3, r3 = A6, r4 = A9, r5 = A12;
//VERDE
//int A1 = A1, A2 = A4, A3 = A7, A4 = A10, A5 = A13;
//AZUL
//int A1 = A2, A2 = A5, A3 = A8, A4 = A11, A5 = A15;

void setup() {
  // put your setup code here, to run once:
//VERMELHO
pinMode(A0, OUTPUT);
pinMode(A3, OUTPUT);
pinMode(A6, OUTPUT);
pinMode(A9, OUTPUT);
pinMode(A12, OUTPUT);

//VERDE
pinMode(A1, OUTPUT);
pinMode(A4, OUTPUT);
pinMode(A7, OUTPUT);
pinMode(A10, OUTPUT);
pinMode(A13, OUTPUT);

//AZUL
pinMode(A2, OUTPUT);
pinMode(A5, OUTPUT);
pinMode(A8, OUTPUT);
pinMode(A11, OUTPUT);
pinMode(A15, OUTPUT);
}

void loop() {
  // ARUUMAR ASA PROTARS
  analogWrite(A0, random(0, 255));
  analogWrite(A1, random(0, 255));
  analogWrite(A2, random(0, 255));

  analogWrite(A3, random(0, 255));
  analogWrite(A4, random(0, 255));
  analogWrite(A5, random(0, 255));
  
  analogWrite(A14, random(0, 255));
  analogWrite(A13, random(0, 255));
  analogWrite(A12, random(0, 255));
  
  analogWrite(A14, random(0, 255));
  analogWrite(A13, random(0, 255));
  analogWrite(A12, random(0, 255));
  
  analogWrite(A14, random(0, 255));
  analogWrite(A13, random(0, 255));
  analogWrite(A12, random(0, 255));
}
