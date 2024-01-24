<?php

echo "Quantos Farenheit esta atualmente? ";
$farenheit = floatval(readline());

$celsius = calcCelsiusParaFarenheit($farenheit);

echo "Atualmente esta " . number_format($celsius, 2) . "C";

function calcCelsiusParaFarenheit($farenheit): float
{
    return 5 * ($farenheit - 32) / 9;
}
