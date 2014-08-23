<html>
<head>
    <title>URL Replacer</title>
</head>
<body>
    <form method="post">
        <input type="text" name="text"/>
        <input type="submit"/>
    </form>
</body>
</html>

<?php

if (isset($_POST['text'])){
    $text = $_POST['text'];
    preg_match_all("/<a\s+([^>]*?\s+)?href=[\"']([^\"]*)['\"]>(.{1,}?)<\/a>/", $_POST['text'], $tags, PREG_PATTERN_ORDER);

    $i = 0;
    foreach ($tags[2] as $tagURL){
        $text = preg_replace("/<a\s+([^>]*?\s+)?href=[\"']([^\"]*)['\"]>(.{1,}?)<\/a>/", "*040*", $text, 1);
        $text = str_replace("*040*", "[URL=\"" . $tagURL . "\"]" . $tags[3][$i] . "[/URL]", $text);
        $i++;
    }
    echo htmlentities($text);
}

?>
