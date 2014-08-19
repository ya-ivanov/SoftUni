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
$counter = 0;
if (isset($_POST["tags"])) {
    $myArr = split(', ',  $_POST['tags'] );
    foreach ($myArr as $tag){
        echo $counter . " : " . " " . $tag . "<br/>";
        $counter++;
    }
}


?>