Algoritmo "Combinacoes"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 13/09/2022
Var
// Seção de Declarações das variáveis 
num, loop, loopD, loopDD:inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
para loop:=1 ate 3 passo 1 faca
loopD:=1
  se (loop=1) entao
    para loopD:=1 ate 3 passo 1 faca
      loopDD:=1
      se loopD=1 entao
      escreval(loop,"",loopD,"",loopDD)
      loopDD:=loopDD+1
      escreval(loop,"",loopD,"",loopDD)
      loopDD:=loopDD+1
      escreval(loop,"",loopD,"",loopDD)
      fimse
      se loopD=2 entao
        escreval(loop,"",loopD,"",loopDD)
        loopDD:=loopDD+1
        escreval(loop,"",loopD,"",loopDD)
        loopDD:=loopDD+1
        escreval(loop,"",loopD,"",loopDD)
      fimse
        se loopD=3 entao
          escreval(loop,"",loopD,"",loopDD)
          loopDD:=loopDD+1
          escreval(loop,"",loopD,"",loopDD)
          loopDD:=loopDD+1
          escreval(loop,"",loopD,"",loopDD)
        fimse
    fimpara
  fimse
  se (loop=2) entao
    para loopD:=1 ate 3 passo 1 faca
      loopDD:=1
      se loopD=1 entao
      escreval(loop,"",loopD,"",loopDD)
      loopDD:=loopDD+1
      escreval(loop,"",loopD,"",loopDD)
      loopDD:=loopDD+1
      escreval(loop,"",loopD,"",loopDD)
      fimse
      se loopD=2 entao
        escreval(loop,"",loopD,"",loopDD)
        loopDD:=loopDD+1
        escreval(loop,"",loopD,"",loopDD)
        loopDD:=loopDD+1
        escreval(loop,"",loopD,"",loopDD)
      fimse
        se loopD=3 entao
          escreval(loop,"",loopD,"",loopDD)
          loopDD:=loopDD+1
          escreval(loop,"",loopD,"",loopDD)
          loopDD:=loopDD+1
          escreval(loop,"",loopD,"",loopDD)
        fimse
    fimpara
  fimse
    se (loop=3) entao
    para loopD:=1 ate 3 passo 1 faca
            loopDD:=1
      se loopD=1 entao
      escreval(loop,"",loopD,"",loopDD)
      loopDD:=loopDD+1
      escreval(loop,"",loopD,"",loopDD)
      loopDD:=loopDD+1
      escreval(loop,"",loopD,"",loopDD)
      fimse
      se loopD=2 entao
        escreval(loop,"",loopD,"",loopDD)
        loopDD:=loopDD+1
        escreval(loop,"",loopD,"",loopDD)
        loopDD:=loopDD+1
        escreval(loop,"",loopD,"",loopDD)
      fimse
        se loopD=3 entao
          escreval(loop,"",loopD,"",loopDD)
          loopDD:=loopDD+1
          escreval(loop,"",loopD,"",loopDD)
          loopDD:=loopDD+1
          escreval(loop,"",loopD,"",loopDD)
        fimse
    fimpara
  fimse
 escreval("")
fimpara

Fimalgoritmo