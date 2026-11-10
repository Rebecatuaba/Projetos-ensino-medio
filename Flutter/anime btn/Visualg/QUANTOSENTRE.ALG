Algoritmo "quantosEntre"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/09/2022
Var
// Seção de Declarações das variáveis 
i, imp, l, s:inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreval("Digite valor entre 0 e 10: ")
leia(i)

se (i<=10) e (i>=0) entao
para l<-i ate 10 passo 1 faca
se nao(l%2=0) entao
imp<-imp+1
s<-s+l
fimse
fimpara
escreval("Teve um total de ", imp," impares")
escreva("A soma dos impares é de: ", s)
fimse
Fimalgoritmo