Algoritmo "conversorMoedas"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 24/05/2022
Var
// Seção de Declarações das variáveis 
reais, dolar, op: real
conversao, i: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreva("Digite quantas conversões queiras? ")
leia (conversao)
enquanto (i<conversao)faça
  escreva ("Digite o valor do dolar hoje: ")
  leia (dolar)
  escreva ("Digite o valor em reais: ")
  leia (reais)
  i := i+1
  op := reais/dolar
  escreval ("Com R$", reais,", você consegue comprar US$", op)
 Fimenquanto
Fimalgoritmo