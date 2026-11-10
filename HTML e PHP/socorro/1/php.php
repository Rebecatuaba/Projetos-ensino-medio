<?php
    $numero=$_POST["numero"];
    if ($numero%3>=1){
        echo "O numero nao e divisivel por 3";
    }else{
        echo "O numero e divisivel por 3";
    }

?>