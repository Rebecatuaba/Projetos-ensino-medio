<?php

$servidor = "localhost";
$banco = "test";
$usuario = "root";
$senha = "";

try{
    $conn = new PDO(
        'mysql:host='.$servidor.';dbname='.banco, $usuario, $senha
    );
}catch (PDOException $e){
    echo "Erro $e";
}

?>