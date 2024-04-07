<?php

const QUANTIDADE_DE_ENTRADA = 3;

echo "Digite " . QUANTIDADE_DE_ENTRADA . " numeros\n";

$numeros = [];
for ($i = 0; $i < QUANTIDADE_DE_ENTRADA; $i++) {
    $numero = floatval(readline());
    array_push($numeros, $numero);
}

sort($numeros);

for ($i = QUANTIDADE_DE_ENTRADA - 1; $i >= 0; $i--) {
    echo $numeros[$i];
}
