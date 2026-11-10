<?php   
  $preco=$_POST["preco"];
  $cupom=$_POST["cupom"];
  $porcent = 0;
  switch($cupom){
    case 1:
        $porcent = $preco*(10/100);
        
        break;
        case 2:
            $porcent = $preco*(20/100);
            break;
            case 3:
                $porcent = $preco*(30/100);
                break;
                case 4:
                    $porcent = $preco*(40/100);
                    break;
                    case 5:
                        $porcent = $preco*(50/100);
                        break;
                      
                    }
$preco=$preco - $porcent;
echo "o preço sera". " ". $preco;
?>