<?php

echo "Digite o salario para calcular o reajuste.\t";
$salario = floatval(readline());

$novoSalario = 0;
$percentual = 0;
if ($salario <= 280) {
    $novoSalario = $salario * 1.2;
    $percentual = 20;
} elseif ($salario < 700) {
    $novoSalario = $salario * 1.15;
    $percentual = 15;

} elseif ($salario < 1500) {
    $novoSalario = $salario * 1.1;
    $percentual = 10;

} elseif ($salario > 1500) {
    $novoSalario = $salario * 1.05;
    $percentual = 5;
}

$valorAumentado = $novoSalario - $salario;

echo "\nSalario Antes do Reajuste: R$" . $salario;
echo "\nPercentual Aplicado: " . $percentual . "%";
echo "\nValor do Aumento: R$" . $valorAumentado;
echo "\nNovo Salario: R$" . $novoSalario;
