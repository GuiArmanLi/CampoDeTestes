<?php

echo "Digite seu salario por hora\t";
$salarioHora = floatval(readline());

echo "Digite quantas horas trabalhou no mes\t";
$horasTrabalhadas = intval(readline());


$salarioBruto = $salarioHora * $horasTrabalhadas;

$impostoRenda = 0.11 * $salarioBruto;
$INSS = 0.08 * $salarioBruto;
$sindicato = 0.05 * $salarioBruto;

$salarioLiquido = $salarioBruto - ($impostoRenda + $INSS + $sindicato);


echo "\nSalario Bruto: R$" . $salarioBruto;
echo "\nPagou R$" . $INSS . " ao INSS";
echo "\nSalario Liquido: R$" . $salarioLiquido;
