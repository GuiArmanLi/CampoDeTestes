<?php

echo "Digite um lado do Quadrado\n";

$lado = getLado();
$area = calcularAreaQuadrado($lado);
$dobroArea = $area * 2;

echo "Area do quadrado = " . $area . "\n";
echo "Dobro da area = " . $dobroArea;

function getLado(): float
{
    return floatval(readline());
}

function calcularAreaQuadrado($lado): float
{
    return $lado * 4;
}



