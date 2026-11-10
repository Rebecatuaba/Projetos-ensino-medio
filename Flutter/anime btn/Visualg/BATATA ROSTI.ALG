Algoritmo "Batata rosti"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 05/04/2022
Var
// Seção de Declarações das variáveis
nota, notas, notao, media:real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
escreva("Digite a primeira nota: ")
leia(nota)
escreva("Digite a segunda nota: ")
leia(notas)
escreva("Digite a terceira nota: ")
leia(notao)
media:= nota + notas + notao
media:= media /3
se(media>=9)entao
escreva("A")
fimse
se(media>=7.5) E (media<9)entao
escreva("B")
fimse
se(media>=6) E (media<7.5)entao
escreva("C")
fimse
se(media>=4) E (media<6)entao
escreva("D")
fimse
se(media<4)entao
escreva("E")
fimse

Fimalgoritmo