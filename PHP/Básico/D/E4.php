<?php

echo "Digite uma letra\t";

$letra = readline();
switch ($letra) {
    case "a";
    case "A";
    case "e";
    case "E";
    case "i";
    case "I";
    case "o";
    case "O";
    case "u";
    case "U";
        echo "Vogal";
        break;

    default:
        echo "Consoante";
}
