<?php

echo "Digite a area a ser pintada.\t";
$areaAPintar = floatval(readline());

const AREA_PINTADA_POR_LATA = 108;
const AREA_PINTADA_POR_GALAO = 21.6;

const VALOR_LATA = 80;
const VALOR_GALAO = 25;

$quantidadeDeLatas = 0;
$quantidadeDeGaloes = 0;

$valorApenasLatas = ceil($areaAPintar / AREA_PINTADA_POR_LATA) * VALOR_LATA;

$valorApenasGaloes = ceil($areaAPintar / AREA_PINTADA_POR_GALAO) * VALOR_GALAO;

$totalMisto = 0;
if ($areaAPintar > AREA_PINTADA_POR_LATA) {
    $quantidadeDeLatas = $areaAPintar / AREA_PINTADA_POR_LATA;

    $restanteAPintar = $areaAPintar % AREA_PINTADA_POR_LATA;
    $quantidadeDeGaloes = ceil($restanteAPintar / AREA_PINTADA_POR_GALAO);

    $totalMisto = $quantidadeDeLatas * VALOR_LATA + $quantidadeDeGaloes * VALOR_GALAO;
}

echo "\nComprando apenas Latas de 18L: R$" . $valorApenasLatas;
echo "\nComprando apenas Galoes de 3,6L: R$" . $valorApenasGaloes;

echo "\nMisturando Latas e Galoes: R$" . round($totalMisto, 2);

