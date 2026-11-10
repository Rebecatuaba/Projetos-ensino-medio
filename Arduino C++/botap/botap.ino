int lg = 3, lr = 4;
int btn = 2, estado, i = 0;

void setup() {
  // put your setup code here, to run once:
  pinMode (lg, OUTPUT);
  pinMode (lr, OUTPUT);
  pinMode (btn, INPUT_PULLUP);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  estado = digitalRead(btn);

  if (estado == LOW) {
    if (i == 0) {
      i = 1;
      Serial.println(i);
      digitalWrite(lr, LOW);
      digitalWrite(lg, HIGH);
      delay(1000);
    } else {
      i = 0;
      Serial.println(i);
      digitalWrite(lg, LOW);
      digitalWrite(lr, HIGH);
      delay(1000);
    }
  }
}
