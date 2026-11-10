Algoritmo "StatusFut"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 10/05/2022
Var
// Seção de Declarações das variáveis
golsX, golsY, dif:inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
Escreva("Escreva a quantidade de gols do time X:")
leia(golsX)
Escreva("Escreva a quantidade de gols do time Y:")
leia(golsY)
se golsX > golsY entao
dif := golsX-golsY
senao
se golsX<golsY entao
dif := golsY-golsX
fimse
fimse

escolha dif
caso 0
Escreva("Empate")
caso 1
Escreva("Partida normal")
caso 2
Escreva("Partida normal")
caso 3
Escreva("Partida normal")
caso 4
Escreva("Goleada")
caso 5
Escreva("Goleada")
caso 6
Escreva("Goleada")
outrocaso
Escreva("Brasil X Alemanha em 2014")
fimescolha
Fimalgoritmo