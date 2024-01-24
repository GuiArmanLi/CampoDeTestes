<?php

echo "Digite o tamanho do arquivo para Download (MB)\t";
$tamanhoDoArquivo = floatval(readline());

echo "Digite da Internet (Mbps)\t";
$internetVel = floatval(readline());

$tempo = ($tamanhoDoArquivo / $internetVel) / 60;

echo "Tempo estimado de " . round($tempo, 2) . " minutos para fazer o Download";
