<?php

function sum(...$numbers)
{
    $sum = 0;
    $len = count($numbers);
    for ($i = 0; $i < $len; $i++) {
        $sum += $numbers[$i];
    }

    return $sum;
}

$arr = array(1, 2, 1, 2, 1, 2, 1, 2);
$result = sum(1, 2, 3, 4, 5); #Ainda nao sei como posso passar um array direto
echo $result;



?>