<?php

session_start();


if ( !isset($_SESSION['Nome']) and !isset($_SESSION['Senha'])) {

    session_destroy();

    unset ($_SESSION['Nome']);
    unset ($_SESSION['Senha']);

    header('location:login.html');

}

if ( isset( $_SESSION["sessiontime"])) {
//////////////????????///////////
    if ($_SESSION["sessiontime"] < time()){
        session_unset();
        echo "Seu tempo expirou!";
        echo "<script>alert('Seu tempo de sessão expirou!!');window.location='login.html'</script>";
       

    }else{
        echo 'Voce ainda esta logado!' .$_SESSION['Nome'];
        $_SESSION["sessiontime"] = time() + 60;
        echo "<script>
            location.replace('BemVindoDeVolta.html');
        </script>";
    }
}else{
    session_unset();
}


?>