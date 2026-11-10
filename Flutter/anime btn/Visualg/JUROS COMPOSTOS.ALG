Algoritmo "Juros compostos"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 26/04/2022
Var
// Seção de Declarações das variáveis 
emp, taxa, juros, mont:Real
mes: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreva("Digite o valor do empréstimo: ")
leia(emp)
escreva("Digite o valor da taxa dos juros: ")
leia(taxa)
escreva("Digite a quantidade de mêses a ser pago: ")
leia(mes)
juros<- taxa/100
para mes de 1 ate mes faca
emp <- (emp) + (emp*juros)
escreval(mes, "° mes = R$ " ,emp)
{
mont<-(emp*(1+taxa^mes))
mont := emp*(1 + taxa) ^ mes
juros<-mont-emp
escreva(juros)

mont<- juros-juros*taxa/100
escreva(mont)
mont<- emp - mont
escreva(mont)
juros<-emp+mont
escreval(mont)

mes<- mes+1
fimpara
escreva("O valor a pagar é ",juros)
}
Fimalgoritmo