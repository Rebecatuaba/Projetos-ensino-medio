function calcular(){
var qtde=document.getElementById("qtde").value
var valor=document.getElementById("valor").value
var resultado=qtde*valor
return resultado
}
function mostrar(){
    var produto=document.getElementById("produto").value
    var entrega=calcular()*10/100
    var total=calcular()+entrega
    alert("Produto: "+produto+"; Valor: R$"+total)
    alert("Custo de entrega: R$"+entrega)
}