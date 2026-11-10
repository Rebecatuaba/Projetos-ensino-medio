Algoritmo "HenderCar"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/06/2022
Var
// Seção de Declarações das variáveis 
preco,desconto:real
comb:caracter

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
Escreva("Digite o valor do veiculo: ")
leia(preco)
se(preco>0)entao
EscrevaL("Escolha o tipo de combustivel:")
EscrevaL("[A]- Álcool")
EscrevaL("[G]- Gasolina")
EscrevaL("[D]- Disel")
leia(comb)
   escolha comb
   caso "A"
     desconto := preco-(preco*0.12)
     Escreval("O valor do carro com desconto é de ",desconto)
     desconto := preco-desconto
     Escreva("O valor do desconto é de ",desconto)
   caso "G"
     desconto := preco-(preco*0.08)
     Escreval("O valor do carro com desconto é de ",desconto)
     desconto := preco-desconto
     Escreva("O valor do desconto é de ",desconto)
   caso "D"
     desconto := preco-(preco*0.06)
     Escreval("O valor do carro com desconto é de ",desconto)
     desconto := preco-desconto
     Escreva("O valor do desconto é de ",desconto)
   fimescolha
fimse
Fimalgoritmo