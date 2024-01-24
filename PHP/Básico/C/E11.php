<?php

echo "Digite 2 numeros inteiros e 1 real\n";

$num1 = intval(readline());
$num2 = intval(readline());
$num3 = floatval(readline());

$result1 = ($num1 * 2) + ($num2 / 2);
$result2 = ($num1 * 3) + $num3;
$result3 = pow($num3, 3);

echo "\nDobro do primeiro com Metado do segundo = " . $result1;
echo "\nSoma do triplo do primeiro com o Terceiro = " . $result2;
echo "\nTeceiro elevado ao cubo = " . $result3;
