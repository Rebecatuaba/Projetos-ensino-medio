int r = A9, g = A8, b = A10, valor;
void setup() {
  // put your setup code here, to run once:
  pinMode(A10, OUTPUT);
  pinMode(A8, OUTPUT);
  pinMode(A9, OUTPUT);
  pinMode(A2, INPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  valor = analogRead(A2);
  Serial.println(valor);
  if (valor <= 920) {
    analogWrite(r, 255);
    analogWrite(g, 0);
    analogWrite(b, 0);
  }
  if (valor >= 1000) {
    analogWrite(g, 255);
    analogWrite(r, 0);
    analogWrite(b, 0);
  }
  if ((valor < 1000) && (valor > 920)) {
    analogWrite(g, 0);
    analogWrite(r, 0);
    analogWrite(b, 255);
  }
}
