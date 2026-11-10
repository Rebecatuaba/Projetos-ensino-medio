Algoritmo "valoresPares"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/09/2022
Var
// Seção de Declarações das variáveis 
inicial, fim, d: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreva("Digite o valor inicial: ")
leia(inicial)
escreva("Digite o valor final: ")
leia(fim)

se inicial<fim entao

para d<-inicial ate fim passo 1 faca
se (d%2=0) entao
 escreval(d)
 
fimse
fimpara

senao
para d <- inicial ate fim passo -1 faca
se (d%2=0) entao
 escreval(d)
 
fimse
 fimpara
 fimse
Fimalgoritmo