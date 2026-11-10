<?php
$host = "localhost";
$user = "root";
$pass = "";
$banco = "bancouwu";


$conexao = @mysqli_connect($host,$user,$pass,$banco) or die ("Problemas com conexão do Banco de Dados");

$query = mysqli_query($conexao, "select * from informacao");


$dados=mysqli_fetch_array($query);

$dados['Nome'];
$dados['Idade'];
$dados['Sexo'];
$dados['Genero'];
$dados['Idade'];

@mysqli_error($conexao);



while($dados=mysqli_)


 include_once('conexao.php');

    if(!$query){
        die("Query Inválida:". @mysqli_error($conexão));
    }

    $dados = mysqli_fetch_array($query);

    echo "<b>ID:</b>".$dados["ID"]."<br>";  
    echo "<b>Nome:</b>".$dados["Nome"]."<br>";  
    echo "<b>Sexo:</b>".$dados["Sexo"]."<br>";  
    echo "<b>Genero:</b>".$dados["Genero"]."<br>";  

mysqli_close($conexão);
  
if($conexao->query($resultado) === TRUE){
  echo 'Cadastrado com Sucesso!'
} else {
  echo 'Eita, moio ao inserir os dados: ', $conexao->error;
}




?>