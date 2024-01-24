<?php

echo "Quanto ganha por hora? ";
$salarioPorHora = floatval(readline());

echo "Quantas horas trabalha por mes? ";
$horasTrabalhadas = intval(readline());

$salarioTotal = $salarioPorHora * $horasTrabalhadas;

echo "Salario = " . $salarioTotal;
