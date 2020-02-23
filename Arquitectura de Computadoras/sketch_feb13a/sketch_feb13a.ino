//ElectronicaStore.Net
const int pins[7] = { 2, 3, 4, 5, 6, 7, 8 };
 
const byte numbersDisplayAnode[10] = {0b1000000, //0
0b1111010, //1
0b0100100, //2
0b0101000, //3
0b0011010, //4
0b0001001, //5
0b0000001, //6
0b1111000, //7
0b0000000, //8
0b0011000}; //9
 
void setup() {
 
for(int i = 0; i < 7; i++) {
pinMode(pins[i], OUTPUT);
}
 
lightSegments(0);
}
 
void loop() {
 
for(int i = 0; i < 10; i++) {
lightSegments(i);
delay(1000);
}
}
 
void lightSegments(int number) {
byte numberBit = numbersDisplayAnode[number];
for (int i = 0; i < 7; i++) {
int bit = bitRead(numberBit, i);
digitalWrite(pins[i], bit);
}
}
