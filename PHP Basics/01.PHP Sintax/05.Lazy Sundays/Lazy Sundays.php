<?php

$today = getdate();
$now = mktime(0,0,0,$today["mon"],$today["wday"], $today["year"]);
$month = $today["mon"];

while ($today["mon"] == $month && $today["wday"] < 32){
    $now = mktime(0,0,0,$today["mon"],$today["wday"], $today["year"]);
    if (date("D", $now) == "Sun"){
        echo $today["wday"] . "rd " . $today["month"] . ", " . $today["year"] . "\n";
    }
    $today["wday"]++;
}

?>