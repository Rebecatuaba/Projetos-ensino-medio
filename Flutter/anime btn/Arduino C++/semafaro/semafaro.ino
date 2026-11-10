int g1 = 2;
int g2 = 3;
int y1 = 4;
int y2 = 5;
int r1 = 6;
int r2 = 7;
 
  
void setup()
{
  pinMode(r1, OUTPUT);
  pinMode(y1, OUTPUT);
  pinMode(g1, OUTPUT);
  
  pinMode(r2, OUTPUT);
  pinMode(y2, OUTPUT);
  pinMode(g2, OUTPUT);
  
}


void loop(){
  
  ////////MOMENTO 1/////////
  digitalWrite(g1, HIGH);
    digitalWrite(y1, LOW);
  digitalWrite(r1, LOW);
  
    digitalWrite(g2, LOW);
    digitalWrite(y2, LOW);
  digitalWrite(r2, HIGH);
    delay(4000);
  
  /////////MOMENTO 2////////
  digitalWrite(g1, LOW);
    digitalWrite(y1, HIGH);
  digitalWrite(r1, LOW);
  
    digitalWrite(g2, LOW);
    digitalWrite(y2, LOW);
  digitalWrite(r2, HIGH);
    delay(4000);
  
  /////////MOMENTO 3////////
    digitalWrite(g1, LOW);
    digitalWrite(y1, LOW);
  digitalWrite(r1, HIGH);
  
    digitalWrite(g2, HIGH);
    digitalWrite(y2, LOW);
  digitalWrite(r2, LOW);
    delay(4000);
  
  /////////MOMENTO 4////////
    digitalWrite(g1, LOW);
    digitalWrite(y1, LOW);
  digitalWrite(r1, HIGH);
  
    digitalWrite(g2, LOW);
    digitalWrite(y2, HIGH);
  digitalWrite(r2, LOW);
    delay(4000);
  
}
  
  
