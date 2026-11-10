// C++ code
//
int sequencia[32] = {};
int btn[4] = {2, 3, 4, 5};
int leds[4] = {9, 10, 11, 12};
int rodada = 0;
int passo = 0;
bool game_over = false;

void setup()
{
  Serial.begin(9600);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(2, INPUT_PULLUP);
  pinMode(3, INPUT_PULLUP);
  pinMode(4, INPUT_PULLUP);
  pinMode(5, INPUT_PULLUP);
  Serial.begin(9600);
}


void loop() {
  proximaRodada();
  reproduzirSequencia();
  aguardarJogador();
  //NOVO JOGO
  if (game_over == true) {
    sequencia[32] = {};
    rodada = 0;
    passo = 0;
    game_over = false;
  }
  delay(1000);
}


void proximaRodada() {
  int sorteio = random(4);
  sequencia[rodada] = sorteio;
  rodada = rodada + 1;
  Serial.print(sorteio);
}

void reproduzirSequencia() {
  for (int i = 0; i < rodada; i++) {
    digitalWrite(leds[sequencia[i]], HIGH);
    delay(500);
    digitalWrite(leds[sequencia[i]], LOW);
    delay(500);
  }
}

void aguardarJogador() {
  int botao_pressionado = 0;
  for (int i = 0; i < rodada; i++) {
    bool jogada_efetuada = false;
    while (!jogada_efetuada) {
      for (int i = 0; i <= 3; i++) {
        if (digitalRead(btn[i]) == LOW) {
          botao_pressionado = i;
          digitalWrite(leds[i], HIGH);
          delay(300);
          digitalWrite(leds[i], LOW);
          jogada_efetuada = true;
        }
      }
    }


    //verificar a jogada
    if (sequencia[passo] != botao_pressionado) {
      //efeito luminoso/sonoro indicando que o jogador perdeu
      for (int i = 0; i <= 3; i++) {
        digitalWrite(leds[i], HIGH);
        delay(100);
        digitalWrite(leds[i], LOW);
      }
      game_over = true;
      break;
    }
    passo = 0;
}
}
