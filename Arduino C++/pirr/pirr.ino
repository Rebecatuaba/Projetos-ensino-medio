int r = 2, bl = 3, gl = 4;
int b=9, a= 8, c=12, d=11, e=10, f=7, g=6, dp=13;

void apagar(){
  digitalWrite(a, HIGH);
  digitalWrite(b, HIGH);
  digitalWrite(c, HIGH);
  digitalWrite(d, HIGH);
  digitalWrite(e, HIGH);
  digitalWrite(f, HIGH);
  digitalWrite(g, HIGH);
  digitalWrite(dp, HIGH);
}

void setup() {
  // put your setup code here, to run once:
  pinMode(r, OUTPUT);
  pinMode(gl, OUTPUT);
  pinMode(bl, OUTPUT);
  pinMode(5, INPUT);
  
  Serial.begin(9600);

  pinMode(b, OUTPUT);
  pinMode(a, OUTPUT);
  pinMode(c, OUTPUT);
  pinMode(d, OUTPUT);
  pinMode(e, OUTPUT);
  pinMode(f, OUTPUT);
  pinMode(g, OUTPUT);
  pinMode(dp, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  apagar();
  
  if (digitalRead(5) == HIGH) {
    Serial.println("1");
    
  digitalWrite(a, HIGH);
  digitalWrite(b, HIGH); *
  digitalWrite(c, HIGH);*
  digitalWrite(d, HIGH);
  digitalWrite(e, HIGH);
  digitalWrite(f, HIGH);
  digitalWrite(g, HIGH);
  digitalWrite(dp, HIGH);*
    
    digitalWrite(gl, LOW);
    digitalWrite(r, HIGH);
    delay(1000);
  } else {
    Serial.println("0");

  digitalWrite(a, LOW);*
  digitalWrite(b, LOW);*
  digitalWrite(c, LOW);*
  digitalWrite(d, LOW);*
  digitalWrite(e, LOW);*
  digitalWrite(f, LOW);*
  digitalWrite(g, LOW);
  digitalWrite(dp, HIGH);*
    
    digitalWrite(r, LOW);
    digitalWrite(gl, HIGH);
    delay(1000);
  }
}
