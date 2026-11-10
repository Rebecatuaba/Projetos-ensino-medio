int le1, le2, le3, cv1, cv2, cv3;
void setup()
{
  pinMode (A0, INPUT);
  pinMode (A1, INPUT);
  pinMode (A2, INPUT);
  pinMode (8, OUTPUT);
  pinMode (9, OUTPUT);
  pinMode (10, OUTPUT);
}

void loop()
{
  le1 = analogRead (A0);
  le2 = analogRead (A1);
  le3 = analogRead (A2);

  cv1 = map(le1, 0, 1023, 0, 255);
  cv2 = map(le2, 0, 1023, 0, 255);
  cv3 = map(le3, 0, 1023, 0, 255);

  analogWrite(8, cv1);
  analogWrite(9, cv2);
  analogWrite(10, cv3);
}
