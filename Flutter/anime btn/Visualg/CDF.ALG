Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 31/05/2022
Var
// Seção de Declarações das variáveis 
alunos, nota, maiornota, i: real
cdf, nome: caractere
Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
maiornota:= 1
i := 0
escreva ("Escreva quantos alunos tem na turma: ")
leia (alunos)
enquanto (i< alunos) faca
        escreval ("Escreva o nome do aluno: ")
        leia (nome)
        escreval ("Escreva a nota do aluno: ")
        leia (nota)
        i <- i+1

Se (nota >= maiornota) entao
cdf <- (nome)
maiornota<- nota
fimse
fimEnquanto
escreva ("O CDF da turma é ", cdf)
Fimalgoritmo