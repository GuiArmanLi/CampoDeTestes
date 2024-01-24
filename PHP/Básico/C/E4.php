<?php
const QUANTIDADE_DE_NOTAS = 4;

echo "Digite 4 notas para calcular a media Bimestral\n";

$notas = getNotas();
$media = getMedia($notas);

echo "Media do aluno: " . $media;


function getNotas()
{
    $notas = [];
    for ($i = 0; $i < QUANTIDADE_DE_NOTAS; $i++) {
        $nota = intval(readline());

        array_push($notas, $nota);
    }

    return $notas;
}

function getMedia($notas): float
{
    $sum = 0;
    foreach ($notas as $nota) {
        $sum += $nota;
    }

    return $sum / QUANTIDADE_DE_NOTAS;
}
