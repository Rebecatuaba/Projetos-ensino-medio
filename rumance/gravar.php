<?php
include_once('conexao.php');

$Nome = $_POST['Nome'];
$Email = $_POST['Email'];
$Genero = $_POST['Genero'];
$Sexo = $_POST['Sexo'];
$Idade = $_POST['Idade'];
$Senha = $_POST['Senha'];

// Verifique se o email já está cadastrado
$sql_check = "SELECT * FROM informacao WHERE Email = '$Email'";
$result_check = mysqli_query($conn, $sql_check);

if (mysqli_num_rows($result_check) > 0) {
    // O email já está cadastrado, exiba uma mensagem de erro
    echo "<script language='javascript' type='text/javascript'>
        alert('Este email já foi cadastrado. Por favor, escolha outro email.');
        window.location.href='cadastro.html';
    </script>";
    die();
} else {
    // O email não está cadastrado, continue com o processo de cadastro
    $sql_insert = "INSERT INTO informacao (Nome, Email, Genero, Sexo, Idade, Senha) VALUES ('$Nome', '$Email', '$Genero', '$Sexo', '$Idade', '$Senha')";

    $result_insert = mysqli_query($conn, $sql_insert);
    if (!$result_insert) {
        die('Query Inválida: ' . mysqli_error($conn));
    } else {
        echo "<script>
            location.replace('BemVindo.html');
        </script>";
    }

    mysqli_close($conn);
}
?>