#define termometroPin A1  
#define ledPin 13        

void setup() {
  Serial.begin(9600);

  pinMode(ledPin, OUTPUT);
  Serial.println("Starting System...");
  delay(2000);

}

void loop() {
  int valorADC = analogRead(termometroPin);
  float gradosC = (valorADC * (5.0 / 1023.0)) * 100.0; // Celsius
  float gradosF = (gradosC * 9.0 / 5.0) + 32.0; // Farenheit
    // Writting the things
  Serial.print("Celcios: ");
  Serial.println(gradosC);
  Serial.print("Farenheit: ");
  Serial.println(gradosF);

  // Off or On depending on temp
  if (gradosC > 25) {
    digitalWrite(ledPin, HIGH);  // Keeps On when higher than 25°C
  } else {
    digitalWrite(ledPin, LOW);   // Turns Off if lower or equal to 25°C
  }

  delay(1000);  // One update per second