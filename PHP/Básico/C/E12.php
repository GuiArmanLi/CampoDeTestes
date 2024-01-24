<?php

echo "Digite sua altura em Centimetros\n";
$altura = floatval(readline());

$pesoIdeal = calcularPesoIdeal($altura);

echo "Peso ideal = " . $pesoIdeal;

function calcularPesoIdeal($altura): float
{
    return (72.2 * ($altura / 100)) - 58;
}
