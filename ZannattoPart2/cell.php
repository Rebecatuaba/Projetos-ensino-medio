<?php
$Vc = $_GET["custoV"];
$Pv = $_GET["preco"];
$Cmc = $_GET["custoC"];


$X= $Cmc-$Pv;
$X = $Vc/$X;

echo $X. ", ou aprox: ". round($X);
?>