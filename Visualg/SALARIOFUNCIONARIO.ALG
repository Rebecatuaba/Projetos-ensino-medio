Algoritmo "SalarioFuncionario"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 10/05/2022
Var
// Seção de Declarações das variáveis
demp:inteiro
sal, por:real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
Escreva("Digite o salário: R$")
leia(sal)
Escreva("Digite a quantidade de dempendentes: ")
leia(demp)

escolha demp
caso 0
por := sal+sal*(5/100)
caso 1
por := sal+sal*(10/100)
caso 2
por := sal+sal*(10/100)
caso 3
por := sal+sal*(10/100)
caso 4
por := sal+sal*(15/100)
caso 5
por := sal+sal*(15/100)
caso 6
por := sal+sal*(15/100)
outrocaso
por := sal+sal*(18/100)
fimescolha
Escreva("Seu salário é de: R$",por)
Fimalgoritmo