<html>
<head>
    <title>Text Filter</title>
</head>
<body>
    <form method="post">
        <input type="text" name="text" placeholder="Text here..."/>
        <input type="text" name="blacklist" placeholder="Bad words here..."/>
        <input type="submit"/>

    </form>
</body>
</html>

<?php
    if(isset($_POST['text']) && isset($_POST['blacklist'])){
        $blacklist = split(", ", $_POST['blacklist']);
        $text = $_POST['text'];
        foreach ($blacklist as $badWord){
            $text = str_replace($badWord, str_repeat("*", strlen($badWord)), $text);
        }
        echo $text;
    }
?>
