<?php

echo "Digite quantos quilos de Peixe joao pescou.\t";
$kilosPeixe = floatval(readline());

if ($kilosPeixe > 50) {
    $pesoExcedente = $kilosPeixe - 50;
    $multa = $pesoExcedente * 4;

    echo "Joao deve pagar " . $multa . " por R$" . $pesoExcedente . "k que excedeu!";
} else {
    echo "Joao nao foi multado";
}

