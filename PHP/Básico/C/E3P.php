<?php

function getValues()
{
    echo "Digite \"0\" para parar de inserir valores!\n";

    $numbers = [];
    $repeat = true;
    while ($repeat) {

        $number = readline();
        if ($number == 0) {
            $repeat = false;
        }

        array_push($numbers, $number);
    }

    return $numbers;
}

function sum($numbers): int
{
    $sum = 0;

    foreach ($numbers as $number) {
        $sum += intval($number);
    }

    return $sum;
}

$values = getValues();

$result = sum($values);

echo "Soma = " . $result;
