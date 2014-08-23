<html>
<head>
    <title>Color Text</title>
    <link rel="stylesheet" href="styles.css"/>
    <meta charset="utf-8"/>
</head>
<body>

    <form method="post">
        <input type="text" name="text" placeholder="Text here..."/>
        <input type="submit"/>

    </form>

</body>
</html>

<?php

if (isset($_POST['text'])){
    $letters = array();
    preg_match_all("/./", $_POST['text'], $letters, PREG_PATTERN_ORDER);

    foreach ($letters[0] as $letter){
        if (ord($letter) % 2 == 0){
            echo "<span class='red'>$letter </span>";
        } else {
            echo "<span class='blue'>$letter </span>";
        }
    }
}

?>
