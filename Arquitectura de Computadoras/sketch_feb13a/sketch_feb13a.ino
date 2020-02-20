const int LED=13;
const int BOTON=10;

int val=0;
int state=0;
int old_val=0;

void setup(){
  
  pinMode(LED,OUTPUT);
  pinMode(BOTON,INPUT);
  
}
void loop(){
  val=digitalRead(BOTON);
  if((val==HIGH) && (old_val==LOW)){
    state=1-state;
    //delay(10);
  }
  old_val=val;
  if(state==1){
   digitalWrite(LED,HIGH); 
  }else{
    digitalWrite(LED,LOW);
  }
  
}
