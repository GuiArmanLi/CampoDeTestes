<?php

echo "Digite 2 números.\n";
$num1 = readline();
$num2 = readline();

function sum($num1, $num2): int
{
    return $num1 + $num2;
}

$result = sum($num1, $num2);

echo "Soma = " . $result;

