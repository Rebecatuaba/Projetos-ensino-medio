Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 09/08/2022
Var
// Seção de Declarações das variáveis 
opcao, num: real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreval (" _______________________________")
escreval ("|       Escolha um número:      |")
escreval("| ( 1.) para contagem de 1 à 10 |")
escreval("| ( 2.) para contagem de 10 à 1 |")
escreval("| ( 3.) para sair do programa   |")
escreval (" _______________________________")
escreval(" ")
escreval("Resposta: ")
leia (opcao)

Escolha (opcao)

caso 1
//escreva("1, 2, 3, 4, 5, 6, 7, 8, 9, 10")

num<- 0
escreval("")
enquanto num <= 10 faca
escreva (num, " ")
num := num+1
fimenquanto

caso 2
//escreva("10, 9, 8, 7, 6, 5, 4, 3, 2, 1")

num<- 10
escreval("")
enquanto num >= 0 faca
escreva (num, " ")
num := num-1
fimenquanto
caso 3
fimalgoritmo

OUTROCASO
escreval(" ")
escreval("Imbecil, é para escolher uma das três alternativas. Se mata")
escreval("VAI TYOMAR NMO CU FILHO DUMA PUTA IDIOTA")
fimescolha


Fimalgoritmo
