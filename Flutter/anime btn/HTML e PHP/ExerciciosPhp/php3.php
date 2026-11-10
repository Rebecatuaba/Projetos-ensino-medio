<?php
  $catealto =  $_GET["cateto1"];
  $catebai = $_GET["cateto2"];
  $hipotenusa = pow($catealto,2) + pow($catebai,2);
  $hipotenusa=sqrt($hipotenusa);
  echo "A hipotenusa desse triangulo sera", $hipotenusa;
 ?>