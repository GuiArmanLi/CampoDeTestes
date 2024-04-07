<?php

echo "Digite 2 numeros\n";

$num1 = floatval(readline());
$num2 = floatval(readline());

if ($num1 > $num2){
    echo "Primeiro numero maior que o Segundo";
    
} else {
    echo "Segundo numero maior que o Primeiro";
}
