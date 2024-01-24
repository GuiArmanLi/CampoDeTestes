<?php

echo "Quantos Celsius esta atualmente? ";
$celsius = floatval(readline());

$farenheit = calcCelsiusParaFarenheit($celsius);

echo "Atualmente esta " . number_format($farenheit, 2) . "F";

function calcCelsiusParaFarenheit($celsius): float
{
    return $celsius * 1.8 + 32;
}
