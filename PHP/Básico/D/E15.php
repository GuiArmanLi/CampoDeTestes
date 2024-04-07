<?php

echo "Digite os 3 lados de um Triangulo";
$lados = [];

for ($i = 0; $i < 3; $i++) {
    $lado = floatval(readline());
    array_push($lados, $lado);
}

if ($lados[0] + $lados[1] > $lados[2] || $lados[0] + $lados[2] > $lados[1] || $lados[1] + $lados[2] > $lados[0]) {
    if ($lados[0] == $lados[1] && $lados[1] == $lados[2]) {
        echo "Triangulo Equilatero";

    } elseif ($lados[0] == $lados[1] || $lados[0] == $lados[2] || $lados[1] == $lados[2]) {
        echo "Triangulo Isosceles";

    } else {
        echo "Triangulo Escaleno";
    }

} else {
    echo "Os lados informados nao formam um Triangulo";
}
