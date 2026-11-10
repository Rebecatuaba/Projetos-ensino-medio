<?php
$Nome = $_POST['Nome'];
$Senha = $_POST['Senha'];

$host = "localhost";
$user = "root";
$pass = "";
$banco = "bancouwu";

$conn = @mysqli_connect($host, $user, $pass, $banco) or die("Problemas com a conexão do Banco de Dados!!!");

$selecionabd = mysqli_select_db($conn, $banco) or die("Banco de Dados inexistente.");

$sql = mysqli_query($conn, "select * from informacao where Nome = '$Nome' and Senha = '$Senha'");

if (mysqli_num_rows($sql) > 0) {
    session_start();

    $_SESSION['Nome'] = $Nome;
    $_SESSION['Senha'] = $Senha;
    $_SESSION['sessiontime'] = time() + 60;

    header('location:inicio.php');
} else {
    session_destroy();

    unset($_SESSION['Nome']);
    unset($_SESSION['Senha']);

    echo "<script>alert('Usuário e/ou senha inválidos');window.location='login.php'</script>";

    header('location:login.php');
}
?>
