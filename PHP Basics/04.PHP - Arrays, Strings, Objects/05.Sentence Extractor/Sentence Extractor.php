<html>
<head>
    <title>Sentence Extractor</title>
</head>
<body>
    <form method="post">
        <textarea name="text" cols="30" rows="10"></textarea><br>
        <input type="text" name="word" placeholder="Word here..."/><br>
        <input type="submit"/>
    </form>
</body>
</html>

<?php
if (isset($_POST['text']) && isset($_POST['word'])){
    $text = $_POST['text'];
    $word = " " . $_POST['word'];

    $sentences = preg_split("/[\!\.\?]/", $text, -1, PREG_SPLIT_NO_EMPTY);

    foreach($sentences as $sentence){
        if (strpos($sentence, $word) !== false){
            echo $sentence . "<br/>";
        }
    }
}
?>

