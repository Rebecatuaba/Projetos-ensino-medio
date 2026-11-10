<?php
$vTaxa = $_GET["vTaxa"];
$vMaquina = $_GET["vMaquina"];
$qPrest = $_GET["qPrest"];

$taxa = $_GET['taxa'];
$tMensal = 0;

if ($taxa == 'tAnual') {
    $tMensal = pow((1 + ($vTaxa / 100)), (1 / $qPrest));
} else if ($taxa == 'tMensal') {
    $tMensal = pow((1 + ($vTaxa / 100)), (1 / $qPrest));
}

$capital = $vMaquina;
$montante = $capital * $qPrest;
$prestacoes = $montante / $qPrest;

echo "Total do financiamento: " . $montante . "<br>";
echo "Valor das prestações: " . $prestacoes;
?>