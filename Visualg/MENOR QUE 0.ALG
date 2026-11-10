Algoritmo "menor que 0"
//  
//  
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 16/08/2022
Var
// Seção de Declarações das variáveis 
num,test,neg,cont:real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
cont:=0
escreva("Escreva quantos números você quer digitar: ")
leia(test)
enquanto (cont<test) faca
escreva("Escreva o número você quer: ")
leia(num)
   se num<0 entao
neg:=neg+1
senao
Escreva("")
fimse
cont:=cont+1
fimenquanto
escreval("Tem ",neg," números menores que 0")

Fimalgoritmo