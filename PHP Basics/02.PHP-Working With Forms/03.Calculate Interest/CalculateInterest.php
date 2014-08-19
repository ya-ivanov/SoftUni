<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <title>Calculate Interest</title>
</head>
<body>
    <form method="post">
        <label for="amount">Enter Amount</label>
        <input type="text" name="amount" id="amount"/><br/>
        <input type="radio" name="currency" value="USD" id="usd"/>
        <label for="usd">USD</label>
        <input type="radio" name="currency" value="EUR" id="eur"/>
        <label for="eur">EUR</label>
        <input type="radio" name="currency" value="BGN" id="bgn"/>
        <label for="bgn">BGN</label> <br/>
        <label for="interest">Compound Interest Amount</label>
        <input name="interest" id="interest"/><br/>
        <select name="period-months">
            <option value="6">6 Months</option>
            <option value="12">1 Year</option>
            <option value="24">2 Years</option>
            <option value="60">5 Years</option>
        </select>
        <input type="submit" name="submit" value="Calculate">
        <?php
        if ($_POST && isset($_POST["submit"])) {
            if (isset($_POST["amount"]) && isset($_POST["currency"]) && isset($_POST["interest"]) && isset($_POST["period-months"])) {
                if (is_numeric( $_POST["amount"]) && is_numeric($_POST["interest"]) && is_numeric($_POST["period-months"])) {
                    if ($_POST["interest"] > 0 && $_POST["interest"] <= 100) {
                        $numberOfYears = $_POST["period-months"] / 12;
                        $valueAtEndOfPeriod =  $_POST["amount"] * pow(1 + ($_POST["interest"] / 100) / 12, 12 * $numberOfYears);
                        echo formatCurrency($valueAtEndOfPeriod,  $_POST["currency"]);
                    } else {
                        echo "Invalid rate. It should be a number between 0 and 100.";
                    }
                } else {
                    echo "Invalid data.";
                }
            } else {
                echo "You have not filled in all required fields.";
            }
        }

        function formatCurrency($amount, $currency) // Not using break, because of return
        {
            $roundedAmount = round($amount, 2);
            switch ($currency) {
                case "USD":
                    return "$" . $roundedAmount;
                case "EUR":
                    return "€" . $roundedAmount;
                case "BGN":
                    return $roundedAmount . " лв.";
                default:
                    return $roundedAmount;
            }
        }

        ?>
    </form>
</body>
</html>