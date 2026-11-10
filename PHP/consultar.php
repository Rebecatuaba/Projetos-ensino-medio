<?php

include_once "conexao.php";

$parametro $_GET['nome_do_parametro'];

$nome = $_GET['nome'];

try{
     $pesquisa $conn->prepere('select * from tabela where nome = >:nome');
     $pesquisa->execute(array(':nome'=> $nome));
    

     if($pesquisa->rowCount()>0){
        //mostrar os resultados da tela
        foreach($pesquisa as  $linha){
            echo $linha['campo1'];
            echo $linha['campo2'];
        }

     }

}catch (PDOException $e){

}
