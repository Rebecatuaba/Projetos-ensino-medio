<?php
    $a=$_GET['A'];
    $b=$_GET['B'];
    $c=$_GET['C'];
    $delta = pow($b, 2)-4*$a*$c;
    if($delta<0){
        echo"Nao ha raizes reais, otario";
    }elseif($delta==0){
        $x1 = (-$b+sqrt($delta))/2*$a;
        echo"x1 = $x1 e x2 = $x1";
    }else{
        $x1 = (-$b+sqrt($delta))/2*$a;
        $x2 = (-$b-sqrt($delta))/2*$a;
        echo"x1 = $x1 e x2 = $x2";
    }

?>  