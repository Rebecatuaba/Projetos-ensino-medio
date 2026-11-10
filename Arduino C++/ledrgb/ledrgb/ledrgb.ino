int leG, leR, leB, cv1, cv2, cv3;
void setup()
{
  pinMode (A0, INPUT);
  pinMode (A1, INPUT);
  pinMode (A2, INPUT);
  pinMode (2, OUTPUT);
  pinMode (3, OUTPUT);
  pinMode (4, OUTPUT);
}

void loop()
{
  leR = analogRead (A0);
  leG = analogRead (A1);
  leB = analogRead (A2);

  cv1 = map(leR, 0, 1023, 0, 255);
  cv2 = map(leG, 0, 1023, 0, 255);
  cv3 = map(leB, 0, 1023, 0, 255);

  analogWrite(2, cv1);
  analogWrite(3, cv2);
  analogWrite(4, cv3);
}
