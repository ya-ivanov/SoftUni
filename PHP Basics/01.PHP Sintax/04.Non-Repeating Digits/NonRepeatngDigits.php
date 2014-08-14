<?php

$n = 15;
$validNumbers = array();

if (strlen((string)$n) < 3){
    echo "no";
} else {
    for ($i = 100; $i <= 999; $i++) {
        $num = ((string)$i);
        if ($num[0] != $num[1] && $num[1] != $num[2] && $num[0] != $num[2]){
            array_push($validNumbers, $num);
        }
    }
}

 echo(implode(",", $validNumbers));

?>