<?php

echo "Digite a area a ser pintada.\t";
$areaAPintar = floatval(readline());

const AREA_PINTADA_POR_LATA = 54;
$quantidadeDeLatas = 0;

if ($areaAPintar % AREA_PINTADA_POR_LATA == 0) {
    $quantidadeDeLatas = $areaAPintar / AREA_PINTADA_POR_LATA;

} else {
    $quantidadeDeLatas = ceil($areaAPintar / AREA_PINTADA_POR_LATA);
}

$total = $quantidadeDeLatas * 80;

echo "Precisa de " . $quantidadeDeLatas . " Lata para pintar " . $areaAPintar . "M";
echo "\nTotal = R$" . $total . ",00";
