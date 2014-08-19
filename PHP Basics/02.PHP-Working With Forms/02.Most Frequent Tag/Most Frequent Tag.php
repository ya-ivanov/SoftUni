<html>
<head>
    <title>Print Tags</title>
</head>
<body>
<form action="" method="post">
    <p>Enter tags:</p>
    <input type="text" name="tags"/>
    <input type="submit"/>
</form>
</body>
</html>

<?php

class Tag{
    public $occur = 0;
    public $tag = "";
}

if (isset($_POST["tags"])) {
    $GLOBALS["myArr"] = split(', ',  $_POST['tags'] );
    $countedWords = array();
    $tagObjects = array();
    function countWord($word){
        $wordCounter = 0;
        for ($i = 0; $i < count($GLOBALS["myArr"]); $i++) {
            if ($word == $GLOBALS["myArr"][$i]){
                $wordCounter++;
            }
        }
        return $wordCounter;
    }

    foreach ($myArr as $tag){
        if (array_search($tag, $countedWords) == false){
            array_push($countedWords, $tag);
            $tempTag = new Tag();
            $tempTag -> occur = countWord($tag);
            $tempTag -> tag = $tag;
            array_push($tagObjects, $tempTag);
        }
    }

    function tagsSort( $a, $b ) {
        return $a->occur == $b->occur ? 0 : ( $a->occur > $b->occur ) ? 1 : -1;
    }

    usort( $tagObjects, 'tagsSort' );
    $tagObjects = array_reverse($tagObjects);

    foreach ($tagObjects as $tag){
        echo $tag ->tag . " : " . $tag ->occur . " times<br/>";
    }
}
?>