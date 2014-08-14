<html>
    <head>
        <title>Info Table</title>
        <link rel="stylesheet" href="style.css"/>
    </head>
    <body>
        <?php
        $name = "Bruce";
        $phoneNumber = "154-45-1158";
        $age = 17;
        $address = "USA";
        echo "<table>";
        echo "<tr><td class='property'>Name</td><td>$name</td></tr>";
        echo "<tr><td class='property'>Phone Number</td><td>$phoneNumber</td></tr>";
        echo "<tr><td class='property'>Age</td><td>$age</td></tr>";
        echo "<tr><td class='property'>Address</td><td>$address</td></tr>";
        echo "</table>";
        ?>
    </body>
</html>