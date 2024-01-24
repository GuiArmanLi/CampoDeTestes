<?php

echo "Digite o raio de um circulo\n";

$raio = getRaio();
$area = calcularAreaCirculo($raio);

echo "Area do Circulo = " . $area;

function getRaio(): float
{
    return floatval(readline());
}

function calcularAreaCirculo($raio): float
{
    return M_PI * pow($raio, 2);
}
