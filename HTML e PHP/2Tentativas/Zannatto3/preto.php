<?php
// Defina as declarações dos suspeitos
$joao = "Carlos é o criminoso";
$pedro = "Eu não sou criminoso";
$carlos = "Paulo é o criminoso";
$paulo = "Carlos está mentindo";

$criminoso = '';

if (($joao == "verdade" && $pedro == "verdade" && $carlos == "verdade" && $paulo == "verdade") ||
    ($joao == "verdade" && $pedro == "verdade" && $carlos == "verdade" && $paulo == "mentira") ||
    ($joao == "verdade" && $pedro == "verdade" && $carlos == "mentira" && $paulo == "verdade") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "verdade" && $paulo == "verdade") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "verdade" && $paulo == "mentira") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "mentira" && $paulo == "verdade") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "mentira" && $paulo == "mentira")
) {
    $criminoso = "João";
}

if (($joao == "mentira" && $pedro == "verdade" && $carlos == "verdade" && $paulo == "verdade") ||
    ($joao == "mentira" && $pedro == "verdade" && $carlos == "verdade" && $paulo == "mentira") ||
    ($joao == "mentira" && $pedro == "verdade" && $carlos == "mentira" && $paulo == "verdade") ||
    ($joao == "mentira" && $pedro == "mentira" && $carlos == "verdade" && $paulo == "verdade") ||
    ($joao == "mentira" && $pedro == "mentira" && $carlos == "verdade" && $paulo == "mentira") ||
    ($joao == "mentira" && $pedro == "mentira" && $carlos == "mentira" && $paulo == "verdade") ||
    ($joao == "mentira" && $pedro == "mentira" && $carlos == "mentira" && $paulo == "mentira")
) {
    $criminoso = "Pedro";
}

if (($joao == "verdade" && $pedro == "verdade" && $carlos == "verdade" && $paulo == "mentira") ||
    ($joao == "verdade" && $pedro == "verdade" && $carlos == "mentira" && $paulo == "verdade") ||
    ($joao == "verdade" && $pedro == "verdade" && $carlos == "mentira" && $paulo == "mentira") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "verdade" && $paulo == "mentira") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "mentira" && $paulo == "verdade") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "mentira" && $paulo == "mentira")
) {
    $criminoso = "Carlos";
}

if (($joao == "verdade" && $pedro == "verdade" && $carlos == "mentira" && $paulo == "verdade") ||
    ($joao == "verdade" && $pedro == "verdade" && $carlos == "mentira" && $paulo == "mentira") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "verdade" && $paulo == "mentira") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "mentira" && $paulo == "verdade") ||
    ($joao == "verdade" && $pedro == "mentira" && $carlos == "mentira" && $paulo == "mentira")
) {
    $criminoso = "Paulo";
}

if ($criminoso != '') {
    echo "<p>O criminoso é $criminoso.</p>";
} else {
    echo "<p>Não é possível determinar o criminoso com base nas declarações.</p>";
}
?>