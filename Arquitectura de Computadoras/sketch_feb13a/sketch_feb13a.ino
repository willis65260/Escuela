
void setup() { 
for(int i=5;i<13;i++){
  pinMode(i,OUTPUT);
}



}
void loop(){
  for(int j=5;j<13;j++){
    digitalWrite(j,HIGH);
    delay(100);
    digitalWrite(j,LOW);
   // digitalWrite(9,HIGH);
  }
  for(int j=12;j>=5;j--){
    digitalWrite(j,HIGH);
    delay(100);
    digitalWrite(j,LOW);
   // digitalWrite(9,HIGH);
  }
}
