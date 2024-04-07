<?php

echo "Digite F ou M3";
$sexo = readline();

if ($sexo = "F"){
    echo "Feminino";

} elseif ($sexo = "M"){
    echo "Masculino";

} else {
    echo "Sexo Invalido";
}
