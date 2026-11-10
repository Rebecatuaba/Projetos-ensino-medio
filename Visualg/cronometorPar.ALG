Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 13/09/2022
Var
// Seção de Declarações das variáveis 
cont, t : inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreval("Digite um valor: ")
leia(t)
se (t%2=1)entao
t:= t-1
fimse
para cont <- t ate 0 passo -2 faca
escreval(cont)
fimpara

Fimalgoritmo