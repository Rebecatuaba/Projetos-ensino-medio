Algoritmo "Contagem Inteligente"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 31/05/2022
Var
// Seção de Declarações das variáveis 
vi, vf, contagem:real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
Escreva("Digite o valor inicial: ")
leia(vi)
Escreva("Digite o valor final: ")
leia(vf)
se(vi<vf)entao
  enquanto (vi<=vf)faca
    EscrevaL("",vi)
    vi:= vi+1
  fimenquanto
senao
  enquanto (vi>=vf)faca
    EscrevaL("",vi)
    vi:=vi-1
  fimenquanto
fimse
Fimalgoritmo