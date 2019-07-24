#include <DHT.h>
#include <DHT_U.h>

#include "DHT.h"
//Incluindo a bliblioteca do sensor DHT 11
 
#define DHTPIN A1 // pino que estamos conectado
#define DHTTYPE DHT11 // DHT 11
 
// Conecte pino 1 do sensor (esquerda) ao +5V
// Conecte pino 2 do sensor ao pino de dados definido em seu Arduino
// Conecte pino 4 do sensor ao GND
// Conecte o resistor de 10K entre pin 2 (dados) 
// e ao pino 1 (VCC) do sensor
DHT dht(DHTPIN, DHTTYPE);
//Criando um objeto do tipo DHT para armazenar o pino em que ele está conectado e o tipo do sensor (DHT 11)
 
void setup() 
{
  Serial.begin(9600);
  //Inicia a comunicação serial entre o computador e a placa
  dht.begin();
  //Inicia o objeto do tipo dht
}
 
void loop() 
{
  // A leitura da temperatura e umidade pode levar 250ms!
  // O atraso do sensor pode chegar a 2 segundos.
  float h = dht.readHumidity();
  // Variável que armazena a umidade relativa do ar
  float t = dht.readTemperature();
  // Variável que armazena a temperatura
   
  // Testa se o retorno é valido, caso contrário algo está errado.
  if (isnan(t) || isnan(h)) 
  {
    Serial.println("Falha na leitura do sensor");
  } 
  else
  {
     Serial.print(t);
    // Printa a temperatura
     Serial.print(",");
    // Printa uma vírgula
     Serial.println(h);
    // Printa a umidade
  }
  delay(5000);
  // Deixa um atraso de 1 segundo
}
