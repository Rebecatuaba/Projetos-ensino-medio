Algoritmo "REPITA"
// Disciplina   : [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
//  
//  
// 
//  
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 22/08/2022
Var
// Seção de Declarações das variáveis 
neg,num,quant,cont: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
cont:=0
    Escreva("Escreva quantos números você quer digitar: ")
    leia(quant)
REPITA
    escreval("Escreva o número que deseja: ")
    leia(num)
    se num<0 entao
    neg:=neg+1
    senao
    Escreva("")
    fimse
    cont:=cont+1
ATE cont>quant
escreval ("Tem",neg," números menores que zero")
Fimalgoritmo