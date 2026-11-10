<?php
$horario=$_POST["hora"];

if($horario>=6 && $horario<12){
    echo "Manha, Quer um cafezin? ";
}
else if ($horario>=12 && $horario<18){
 echo "Tarde, Mucei";
}
else if($horario>=18 && $horario<24){
    echo"noite, Jantei!";
}
else if($horario>=0 && $horario<6 || $horario==24){
    echo"madrugada, quer um doci?";
}else{
    echo "para de ser burro mlk";
}





?>


