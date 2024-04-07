<?php

echo "Digite 3 numeros\n";

$maiorNumero = PHP_FLOAT_MIN;
$menorNumero = PHP_FLOAT_MAX;
for ($i = 0; $i < 3; $i++) {
    $numero = floatval(readline());

    if ($numero > $maiorNumero) {
        $maiorNumero = $numero;
    }

    if ($numero < $menorNumero) {
        $menorNumero = $numero;
    }
}

echo "\nMaior numero: " . $maiorNumero;
echo "\nMenor numero: " . $menorNumero;
