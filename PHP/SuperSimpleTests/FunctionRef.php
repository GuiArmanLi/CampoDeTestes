<?php 
$pessoa = "Lucas";

function appendName($param){
    $param .= " e g4y";
}
function appendNameByRef(&$param){
    $param .= " e g4y";
}

echo $pessoa;

appendName($pessoa);
echo $pessoa;

appendNameByRef($pessoa);
echo $pessoa;
?>