<?php

echo "Digite em qual periodo voce estuda.\n";
echo "\"M\" = Matutino\t";
echo "\"V\" = Vespertino\t";
echo "\"N\" = Noturno\n";

$periodo = readline();

switch ($periodo) {
    case "M":
        echo "Bom dia!";
        break;
    case "V":
        echo "Boa tarde!";
        break;
    case "N":
        echo "Boa noite!";
        break;
    default:
        echo "Valor invalido!";
}
