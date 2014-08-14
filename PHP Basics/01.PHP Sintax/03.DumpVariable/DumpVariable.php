<?php

$someVar = "Kir4o";
//$someVar = 5;
//$someVar = 3.14;


if (gettype($someVar) == "integer" || gettype($someVar) == "double"){
    var_dump($someVar);
} else {
    echo gettype($someVar);
}

?>