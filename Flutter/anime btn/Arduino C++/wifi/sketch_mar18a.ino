#include "ESP8266WiFi.h"
void setup() {
Serial.begin(9600);
WiFi.mode(WIFI_STA); // Defina o WiFi para o mod estação
WiFi.disconnect(); // Desconecta se o sistema estiver conectado
delay(100);
Serial.println("Configuração pronta");
}
void loop() {
Serial.println("Inicia escaneamento");
int n = WiFi.scanNetworks(); // Retorna número de redes localizadas
Serial.println("Escaneamento terminou");
if (n == 0) {
Serial.println("Nenhuma Rede foi localizada");
} else {

Serial.print(n);
Serial.println("Redes localizadas");
for (int i = 0; i < n; ++i) {
Serial.print(i + 1);
Serial.print(": ");
Serial.print(WiFi.SSID(i)); // Imprime Nome da Rede Wifi

Serial.print(" (");
Serial.print(WiFi.RSSI(i)); // Imprime Intensidade do sinal

Serial.print(")");
Serial.println((WiFi.encryptionType(i) == ENC_TYPE_NONE) ? " " : "*");
delay(10);
}
}
Serial.println("");
delay(5000);
}