
int contador= 0;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
Serial.println("hola que tal");
pinMode(13,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
if( Serial.available() > 0 )
   {
    int dato= Serial.read();
    if (dato=='e')
      {
        digitalWrite(13,HIGH);
        Serial.print("encendido: ");
        Serial.println(contador);
      }
     if (dato=='a')
      {
        digitalWrite(13,LOW);
        Serial.print("apagado: ");
        Serial.println(contador);
      }
    contador++;
    }
 
}
