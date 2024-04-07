<?php

echo "Qual valor da sua Hora?\t";
$salarioPorHora = floatval(readline());

echo "Quantas horas trabalha no mes?\t";
$horasTrabalhadas = floatval(readline());

$salarioBruto = $salarioPorHora * $horasTrabalhadas;


$descontoIR = 0;
$percentualIR = 0;
if ($salarioBruto <= 1500) {
    $descontoIR = $salarioBruto * 0.05;
    $percentualIR = 5;

} elseif ($salarioBruto <= 2500) {
    $descontoIR = $salarioBruto * 0.1;
    $percentualIR = 10;

} else {
    $descontoIR = $salarioBruto * 0.2;
    $percentualIR = 20;
}

$descontoSindicato = $salarioBruto * 0.03;
$descontoFGTS = $salarioBruto * 0.11;
$descontoINSS = $salarioBruto * 0.10;

$totalDescontos = $descontoINSS + $descontoIR;

$salarioLiquido = $salarioBruto - $totalDescontos;

echo "\nSalario Bruto: ($salarioPorHora * $horasTrabalhadas)\t: R$ " . round($salarioBruto, 2);
echo "\n( - ) IR ( $percentualIR% )\t\t\t: R$ " . round($descontoIR, 2);
echo "\n( - ) INSS ( 10% )\t\t: R$ " . round($descontoINSS, 2);
echo "\nFGTS ( 11% )\t\t\t: R$ " . round($descontoFGTS, 2);
echo "\nTotal de Descontos\t\t: R$ " . round($totalDescontos, 2);
echo "\nSalario Liquido\t\t\t: R$ " . ROUND($salarioLiquido, 2);
