Algoritmo "somadorNumericoBobao"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 24/05/2022
Var
// Seção de Declarações das variáveis 
soma, n, maiorN, i: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
enquanto (i<5)faça
  escreval ("escreva um número: ")
  leia (n)
  se (n>maiorN) entao
    maiorN := n
  fimse
  soma := soma + n
  i:= i+1
fimenquanto
escreval("O resultado é igual: ",soma)
escreva("O maior número é: ",maiorN)

Fimalgoritmo