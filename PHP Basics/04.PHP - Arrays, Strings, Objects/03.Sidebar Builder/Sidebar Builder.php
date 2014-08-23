<html>
<head>
    <title>Color Text</title>
    <link rel="stylesheet" href="styles.css"/>
    <meta charset="utf-8"/>
</head>
<body>

    <form method="post" style="margin-bottom: 20px;">
        Categories: <input type="text" name="categories" placeholder="Text here..."/><br/>
        Tags: <input type="text" name="tags" placeholder="Text here..."/><br/>
        Months: <input type="text" name="months" placeholder="Text here..."/><br/>
        <input type="submit" value="Generate"/>
    </form>

</body>
</html>

<?php

if (isset($_POST['categories']) && isset($_POST['tags']) && isset($_POST['months'])){
    $categories = split(", ", $_POST['categories']);
    $tags = split(", ", $_POST['tags']);
    $months = split(", ", $_POST['months']);

    echo '<section><ul><li>Categories</li>';
    foreach ($categories as $category){
        echo "<li>$category</li>";
    }
    echo '</ul></section>';

    echo '<section><ul><li>Tags</li>';
    foreach ($tags as $tag){
        echo "<li>$tag</li>";
    }
    echo '</ul></section>';

    echo '<section><ul><li>Months</li>';
    foreach ($months as $month){
        echo "<li>$month</li>";
    }
    echo '</ul></section>';
}

?>
