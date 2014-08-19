<html>
<head>
    <title>Tags counter</title>
</head>
<body>
<form action="" method="post">
    <p>Enter HTML tags:</p>
    <input type="text" name="tag"/>
    <input type="submit"/>
</form>
</body>
</html>

<?php

session_start();
if (!isset($_SESSION['score'])) {
    $_SESSION['score'] = 0;
}

if (isset($_POST["tag"])){
    $allTags = split(" ", htmlentities('doctype a abbr acronym address applet area b base basefont bdo big blockquote body br button caption center cite code col colgroup dd del dfn dir div dl dt em fieldset font form frame frameset h1 h2 h3 h4 h5 h6 head hr html i iframe img input ins isindex kbd label legend li link map menu meta noframes noscript object ol optgroup option p param pre q s samp script select small span strike strong style sub sup table tbody td textarea tfoot th thead title tr tt u ul var'));
    $enteredTag = $_POST["tag"];
    if (array_search(htmlentities($enteredTag), $allTags) != false){
        echo "<h2>Valid HTML Tag</h2>";
        echo "<h2>Score: " . ++ $_SESSION['score'] . "</h2>";
    } else {
        echo "<h2>Invalid HTML Tag<h2/>";
        echo "<h2>Score: " .  $_SESSION['score'] . "</h2>";
    }
}

?>