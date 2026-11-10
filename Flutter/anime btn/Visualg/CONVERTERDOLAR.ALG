Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 31/05/2022
Var
// Seção de Declarações das variáveis 
C, Q: INTEIRO
R, D: REAL

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
C <- 1
 ESCREVA ("Quantas converções você deseja realizar? ")
 leia (Q)
 ENQUANTO (C <= Q)FACA
        ESCREVAL ("Qual o valor em R$: ")
        leia (R)
        D <- R/4.74
        ESCREVAL (" O valor convertido em USD é: ", D:5:2)
        C <- C+1
 fimEnquanto
 
Fimalgoritmo