<?php

echo "Digite 3 numeros\n";

$maiorNumero = PHP_FLOAT_MIN;
for ($i = 0; $i < 3; $i++) {
    $numero = floatval(readline());

    if ($numero > $maiorNumero) {
        $maiorNumero = $numero;
    }
}

echo "Maior numero: " . $maiorNumero;
