<?php

echo "Digite 2 notas\n";
$nota1 = floatval(readline());
$nota2 = floatval(readline());

$media = ($nota1 + $nota2) / 2;

if ($media == 10) {
    echo "Aprovado com distincao";

} elseif ($media >= 7) {
    echo "Aprovado";
} else {
    echo "Reprovado";
}

