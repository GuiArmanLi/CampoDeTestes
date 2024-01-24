<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>

    <?php
    $var = var_dump(empty($user));

    $user = 10;

    echo "<br>";
    echo "<p> $var </p>";

    $names = array("Papagaio", " de ", 4, true);

    foreach ($names as $name) {
        echo $name;
    }

    ?>

</body>

</html>