Algoritmo "Tab"
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 16/08/2022
Var
// Seção de Declarações das variáveis 
cont, n,r:Inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
cont:=1
Escreval("Qual tabuada você quer ver? ")
leia(n)
Repita
      r:=n*cont
      escreval(n," x ", cont," = ",r)
      cont:=cont+1
ate(cont>10)
Fimalgoritmo