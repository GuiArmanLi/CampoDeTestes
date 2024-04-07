<?php

echo "Digite o valor de 3 produtos\n";

$maisBarato = PHP_FLOAT_MAX;
for ($i = 0; $i < 3; $i++) {
    $valor = floatval(readline());

    if ($valor < $maisBarato) {
        $maisBarato = $valor;
    }
}

echo "Voce deve comprar o produto de R$" . $maisBarato;
