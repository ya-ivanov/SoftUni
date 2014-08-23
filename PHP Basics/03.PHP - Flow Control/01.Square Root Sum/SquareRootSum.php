<html>
<head>
    <title>Square Root Sum</title>
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
    <table>
        <tr>
            <th>Number</th><th>Square</th>
        </tr>
        <?php
        $sum = 0;
        for ($i = 0; $i <= 100; $i+=2) {
            $sum += sqrt($i);
            echo "<tr><td>" . $i . "</td>" . "<td>" . round(sqrt($i), 2) . "</td></tr>";
        }
        echo "<tr><td>Total:</td><td>" . round($sum, 2) . "</td></tr>";
        ?>
    </table>
</body>
</html>

