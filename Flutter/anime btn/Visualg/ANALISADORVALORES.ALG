Algoritmo "AnalisadorValores"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 20/09/2022
Var
// Seção de Declarações das variáveis
soma, par, divCinco, null, num, loop:inteiro
media:real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
para loop:=1 ate 5 passo 1 faca
escreva("Digite um valor: ")
leia(num)
se (num%2)=0 entao
par:=par+1

se num=0 entao
null:=null+1

se(num%5)=0 entao
divCinco:=divCinco+1

fimse
fimse
fimse


soma:=soma+num
fimpara
media:= soma/5
escreval("Número(s) divisiveis por 5: ", divCinco)
escreval("Soma entre os números: ",soma)
escreval("Média dos números: ",media)
escreval("Valores nulos: ",null)
escreva("Total de par(es): ",par)

Fimalgoritmo