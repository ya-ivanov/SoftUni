<html>
<head>
    <title>Primes in range</title>
    <link rel="stylesheet" href="styles.css"/>
</head>
<body>
    <form method="post">
        Starting Index <input type="text" name="start"/>
        Ending Index <input type="text" name="end"/>
        <input type="submit"/>
    </form>
</body>
</html>

<?php
    function isPrime($num) {
        if($num == 1)
            return false;

        if($num == 2)
            return true;

        if($num % 2 == 0)
            return false;

        for($i = 3; $i <= ceil(sqrt($num)); $i = $i + 2)
            if($num % $i == 0)
                return false;

        return true;
    }

    if (isset($_POST['start']) && isset($_POST['end'])){
        for ($i = $_POST['start']; $i <= $_POST['end']; $i++) {
            if (isPrime($i))
                echo "<b style='font-size: 20px; color: #03c100;'>$i</b>, ";
            else
                echo $i . ", ";
        }
    }
?>