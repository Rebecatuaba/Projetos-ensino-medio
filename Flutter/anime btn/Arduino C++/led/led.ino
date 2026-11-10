#include "ESP8266WiFi.h"
const char* ssid = "anchieta-academico";
const char* password = "Anchieta";
int porta = 80;
int a=0;
WiFiServer server(porta);  
String readString;
void setup() {
  Serial.begin(9600);
  pinMode(D6, OUTPUT);
  pinMode(D7, OUTPUT);
  pinMode(D8, OUTPUT);

  // Conecta Rede Wifi

  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED){
    a++;
    if (a<60){
      Serial.print(".");
    } else {
      Serial.println(".");
      a=0;
    }
    delay(100);
  }
  Serial.println("Conectado a rede");
  Serial.println("");
  Serial.println("Servidor Iniciado");
  // Inicia o Servidor Web para receber dados WiFiServer server (porta)
  server.begin();
  // mostra o ip recebido
  Serial.println("IP para conexão");
  Serial.print("http://");
  Serial.println(WiFi.localIP());
}

void loop() {
  WiFiClient client = server.available();  // Verifica se algum cliente está conectado ao servidor
      if (!client) { 							// Cliente não conectado, reexecuta processo  
          delay(10);
          return;                                       
      }    
  Serial.println("Novo cliente se conectou!"); 

  // enquanto cliente estiver conectado espera 1 segundo
  while(!client.available()){                       
          delay(1);                                     
  }
  while (client.connected()){
    if (client.available()){
      char c = client.read();
      if (readString.length()<100){
        readString += c;
        //Serial.print(readString);
      }
  //String request = client.readStringUntil('\n');  //  Faz leitura da primeira linha da requisição Web
  //Serial.println(request);
  //client.flush();  // Aguarda até todos dados serem enviados ao cliente
      if (c == '\n'){
          client.println("HTTP/1.1 200 OK");                
          client.println("Content-Type: text/html");       
          client.println("");
          //client.println("<!DOCTYPE HTML>");                
          client.println("<html>");           
          client.println("<HEAD>"); 
          client.println("<TITLE>Acionando Leds</TITLE>"); 
          client.println("<META http-equiv=Content-Type content='text/html; charset=iso-8859-1'>");
         // client.println("<META HTTP-EQUIV='refresh' CONTENT='5'>");
          client.println("</HEAD>");      
          client.println("<body>"); 

          client.println("Ligando leds<br>");
          
          client.println("<a href=/?led1on>Ligar led 1</a><br>");
          client.println("<a href=/?led1off>Desligar led 1</a><br>");
          client.println("<a href=/?led2on>Ligar led 2</a><br>");
          client.println("<a href=/?led2off>Desligar led 2</a><br>");
          client.println("</body>"); 
          client.println("</html>"); 
         
          delay(20);
          client.stop();

          //Serial.println(readString);
          if(readString.indexOf("?led1on") > 0){
            digitalWrite(D6, HIGH);
          } else {
            if(readString.indexOf("?led1off") > 0){
              digitalWrite(D6, LOW);
            }
          }
          readString="";
      }
    }
  }
}