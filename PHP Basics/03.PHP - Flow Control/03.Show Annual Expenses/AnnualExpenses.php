<html>
<head>
    <title>Annual Expenses</title>
    <link rel="stylesheet" href="styles.css"/>
</head>
<body>
    <form method="post">
        Number of years <input type="text" name="years"/>
        <input type="submit"/>
    </form>
</body>
</html>

<?php
    if (isset($_POST['years'])){

        $GLOBALS['expenses'] =  0;
        function getRandomExpenses(){
            $tempRand = rand(0, 999);
            $GLOBALS['expenses'] += $tempRand;
            return $tempRand;
        }

        echo '<table>';
        echo '<tr><th>Year</th><th>January</th><th>February</th><th>March</th><th>April</th><th>May</th><th>June</th><th>July</th><th>August</th><th>September</th><th>October</th><th>November</th><th>December</th><th>Total</th></tr>';
        $year = 2014;
        for ($i = $_POST['years']; $i > 0; $i--) {
            if ($i % 2 == 0)
                echo '<tr class="whiteRow"><td>' . $year-- . '</td>';
            else
                echo '<tr class="grayRow"><td>' . $year-- . '</td>';

            for ($k = 0; $k < 12; $k++) {
                    echo '<td>' . getRandomExpenses() . '</td>';
            }

            echo '<td>' . $GLOBALS['expenses'] . '</td></tr>';
            $GLOBALS['expenses'] = 0;
        }
        echo "</table>";
    }
?>