<?php
               // CONEXAO COM BD //
               
$host = "localhost";
$user = "root";
$pass = "";
$banco = "bancouwu";

// Cria uma conexão
$conn = new mysqli($host, $user, $pass, $banco);

// Verifica a conexão
if ($conn->connect_error) {
    die("Falha na conexão: " . $conn->connect_error);
}

?>