<?php

echo "Digite 2 Notas\n";
$nota1 = floatval(readline());
$nota2 = floatval(readline());

$media = ($nota1 + $nota2) / 2;

$conceito = "";
$estaAprovado = "Nao";
switch ($media) {
    case $media >= 9:
        $conceito = "A";
        $estaAprovado = "Sim";
        break;

    case $media >= 7.5 && $media < 9:
        $conceito = "B";
        $estaAprovado = "Sim";
        break;

    case $media >= 6 && $media < 7.5:
        $conceito = "C";
        $estaAprovado = "Sim";
        break;

    case $media >= 4 && $media < 6:
        $conceito = "D";
        break;
    case $media < 4:
        $conceito = "E";
        break;

    default:
        echo "Valor Incorreto!";
}

echo "Nota: $media \t Conceito: $conceito \t Esta Aprovado? $estaAprovado";
