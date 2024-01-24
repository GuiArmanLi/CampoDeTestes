<?php

echo "Conversor de M para Cm";
echo "Digite quantos metros gostaria de converter\n";

$metros = getMetros();
$centimetros = converterMetrosParaCent($metros);

echo $metros . "m = " . $centimetros . "cm";

function getMetros(): float
{
    return floatval(readline());
}

function converterMetrosParaCent($metros): float
{
    return $metros * 100;
}
