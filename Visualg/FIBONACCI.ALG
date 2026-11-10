Algoritmo "fibonacci"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 13/09/2022
Var
// Seção de Declarações das variáveis 
suc, anc, fibo, loop:inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
anc:=0
suc:=1
escreval(anc)
escreval(suc)
para loop:=3 ate 15 passo 1 faca
  fibo:=anc+suc
  escreval(fibo)
  anc:=suc
  suc:=fibo
fimpara

Fimalgoritmo