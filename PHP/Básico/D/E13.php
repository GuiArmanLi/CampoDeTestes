<?php

echo "Digite um numero de 1 - 7\t";
$numero = intval(readline());

switch ($numero) {
    case 1:
        echo "Domingo";
        break;
    case 2:
        echo "Segunda";
        break;
    case 3:
        echo "Terca";
        break;
    case 4:
        echo "Quarta";
        break;
    case 5:
        echo "Quinta";
        break;
    case 6:
        echo "Sexta";
        break;
    case 7:
        echo "Sabado";
        break;
    default:
        echo "Valor invalido";
}
