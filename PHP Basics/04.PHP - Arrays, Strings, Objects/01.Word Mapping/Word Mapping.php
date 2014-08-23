<html>
<head>
    <title>Word Mapping</title>
    <link rel="stylesheet" href="styles.css"/>
</head>
<body>
    <form method="POST">
        <textarea name="text" cols="30" rows="10" placeholder="Text here..."></textarea>
        <input type="submit" value="Count Words"/>
    </form>
</body>
</html>

<?php
$usedWords = array();
function countOccur($arr, $wordToCount){
    $times = 0;
    foreach ($arr as $word){
        if (strtolower($word) == strtolower($wordToCount)){
            $times++;
        }
    }
    return $times;
}

if (isset($_POST['text'])){
    $text = $_POST['text'];
    $words = array();
    preg_match_all("/\b\w+\b/", $text, $words, PREG_PATTERN_ORDER);

    echo "<table>";

    foreach ($words[0] as $word){
        if (array_search(strtolower($word), $usedWords) === false){
            echo "<tr><td>" . $word . "</td><td>" . countOccur($words[0], $word) . '</td></tr>';
            array_push($usedWords, strtolower($word));
        }
    }

    echo "</table>";
}

?>

