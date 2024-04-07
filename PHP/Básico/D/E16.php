<?php

echo "Digite o valor de A, B e C para calcular as raizes reais de equacao\n";
$a = floatval(readline());
if ($a == 0) {
    echo "Equacao nao e de Segundo Grau";
    return null;
}

$b = floatval(readline());
$c = floatval(readline());

$delta = pow($b, 2) - 4 * $a * $c;
if ($delta < 0) {
    echo "Nao possui raizes reais";
    return null;

} elseif ($delta == 0) {
    echo "" . -$b;
    $raiz = (-$b + sqrt($delta)) / 2 * $a;
    echo "Equacao possui uma Raiz Real: $raiz";

} else {
    $raizX = (-$b + sqrt($delta)) / 2 * $a;
    $raizY = (-$b - sqrt($delta)) / 2 * $a;

    echo "Equacao possui duas Raizes Reais: X - $raizX | Y - $raizY";
}
