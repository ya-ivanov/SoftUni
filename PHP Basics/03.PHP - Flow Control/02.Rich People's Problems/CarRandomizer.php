<html>
<head>
    <title>Car Randomizer</title>
    <style>
        table {
            border-collapse: collapse;
            border: 1px solid black;
        }

        th, td {
            border: 1px solid black;
            padding: 10px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form method="post">
        Enter cars <input type="text" placeholder="Cars..." name="cars"/>
        <input type="submit" value="Show result"/>
    </form>
</body>
</html>


<?php
    if (isset($_POST['cars'])){
        $colors = ['yellow', 'orange', 'white', 'blue', 'black', 'red', 'silver', 'gold'];
        $cars = array();
        $cars = explode(", ", $_POST['cars']);
        echo '<table>';
        echo "<tr><th>Car</th><th>Color</th><th>Count</th></tr>";

        for ($i = 0; $i < count($cars); $i++) {
            echo "<tr><td>" . $cars[$i] . "</td><td>" . $colors[rand(0, count($colors)-1)] . "</td><td>" . rand(1, 5) . "</td></tr>";
        }

        echo "</table>";
    }
?>