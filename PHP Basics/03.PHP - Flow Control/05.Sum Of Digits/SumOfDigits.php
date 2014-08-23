<html>
<head>
    <title>Sum of Digits</title>
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
        Input String <input type="text" name="nums"/>
        <input type="submit"/>
    </form>
</body>
</html>

<?php

    function sumNumbers($nums){
        $sum = 0;
        for ($i = 0; $i < strlen($nums); $i++) {
            if (is_numeric($nums[$i])){
                $sum += intval($nums[$i]);
            } else {
                return "I can't sum that.";
            }
        }
        return $sum;
    }

    if (isset($_POST['nums'])){
        $numbers = explode(", ", $_POST['nums']);
        echo '<table>';

        foreach ($numbers as $number){
            echo "<tr><td>" . $number . "</td><td>" . sumNumbers($number) . "</td></tr>";
        }

        echo "</table>";

    }
?>