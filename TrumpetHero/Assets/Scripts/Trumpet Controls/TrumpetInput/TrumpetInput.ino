void setup()
{
  Serial.begin(9600);
  
  pinMode(13, OUTPUT);

  pinMode(2, INPUT);
  pinMode(3, INPUT);
  pinMode(4, INPUT);

  digitalWrite(2, HIGH);
  digitalWrite(3, HIGH);
  digitalWrite(4, HIGH);
}

void loop(){
  if(digitalRead(2) == LOW && digitalRead(3) == HIGH)
  {
    Serial.write(3);
    Serial.flush();
    delay(20);
  }
  if(digitalRead(3) == LOW && digitalRead(2) == HIGH && digitalRead(4) == HIGH)
  {
    Serial.write(2);
    Serial.flush();
    delay(20);
  }
  if(digitalRead(4) == LOW && digitalRead(3) == HIGH)
  {
    Serial.write(1);
    Serial.flush();
    delay(20);
  }
  if(digitalRead(4) == LOW && digitalRead(3) == LOW)
  {
    Serial.write(4);
    Serial.flush();
    delay(20);
  }
  if(digitalRead(3) == LOW && digitalRead(2) == LOW)
  {
    Serial.write(5);
    Serial.flush();
    delay(20);
  }
    
  
}
