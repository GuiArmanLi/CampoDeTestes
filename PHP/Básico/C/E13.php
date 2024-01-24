<?php

echo "Digite sua altura em Centimetros\t";
$altura = floatval(readline());

echo "Digite seu sexo. Ex.: \"F\" ou \"M\" \t";
$sexo = readline();

echo "Digite seu peso atual \t";
$peso = floatval(readline());

$pesoIdeal = calcularPesoIdealPorSexo($altura, $sexo);
$situacao = informarSituacao($peso, $pesoIdeal);

echo "\n Peso ideal = " . $pesoIdeal;
echo "Situacao = " . $situacao;

function calcularPesoIdealPorSexo($altura, $sexo): float
{
    if ($sexo == "M") {
        return (72.2 * ($altura / 100)) - 58;

    } elseif ($sexo == "F") {
        return (62.1 * ($altura / 100)) - 44.7;
    } else {
        echo "Sexo incorreto";
        return 0;
    }
}

function informarSituacao($peso, $pesoIdeal): string
{
    if ($peso < $pesoIdeal) {
        return "Peso abaixo da media";

    } elseif ($peso > $pesoIdeal - 2 && $peso < $pesoIdeal + 2) {
        return "Peso dentro da media";

    } else {
        return "Peso acima da media";
    }
}
