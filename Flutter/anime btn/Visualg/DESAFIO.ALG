Algoritmo "Desafio"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 17/05/2022
Var
// Seção de Declarações das variáveis 
  numInicial, numFinal, incremento:inteiro
  t:caracter

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
  escreva("Digite o número inicial: ")
    leia(numInicial)
  escreva("Digite o número final: ")
    leia(numFinal)
  escreva("Digite '-' para subtrair e '+' para somar: ")
    leia(t)
  escreva("Digite o valor de soma/subtração: ")
    leia(incremento)
  escolha t
     caso "-"
       enquanto (numInicial>=numFinal) faca
         escreval("",numInicial)
         numInicial := numInicial-incremento
       fimEnquanto
     caso "+"
       enquanto (numInicial<=numFinal) faca
         escreval("",numInicial)
         numInicial := numInicial+incremento
       fimEnquanto
  fimEscolha
Fimalgoritmo