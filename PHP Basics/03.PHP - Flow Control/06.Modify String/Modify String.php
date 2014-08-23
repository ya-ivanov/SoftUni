<html>
<head>
    <title>Modify String</title>
</head>
<body>

    <form method="post">
        <input type="text" name="string"/>
        <label for="palindrome">Check palindrome</label><input type="radio" id="palindrome" name="function" value="palindrome"/>
        <label for="reverse">Reverse string</label><input type="radio" id="reverse" name="function" value="reverse"/>
        <label for="split">Split</label><input type="radio" id="split" name="function" value="split"/>
        <label for="hash">Hash string</label><input type="radio" id="hash" name="function" value="hash"/>
        <label for="shuffle">Shuffle string</label><input type="radio" id="shuffle" name="function" value="shuffle"/>
        <input type="submit"/>
    </form>

</body>
</html>

<?php

function toHashString($str){
    return hash("ripemd160", $str);
}

function splitString($str, $charToSplit){
    $result = array();
    preg_match_all($charToSplit, $str, $result, PREG_PATTERN_ORDER);
    return (array) $result;
}

function reverseString($str){
    $result = "";

    for ($i = strlen($str) -1; $i >= 0; $i--) {
        $result .= $str[$i];
    }
    return $result;
}

function checkPalindrome($str){
    if ($str == reverseString($str)){
        return "$str is a palindrome";
    } else
        return "$str is not a palindrome!";
}

function shuffleString($str){
    return str_shuffle($str);
}


if (isset($_POST['string'])){
    $inputString = $_POST['string'];

    switch ($_POST['function']){
        case "palindrome":
            echo checkPalindrome($inputString);
            break;
        case "reverse":
            echo reverseString($inputString);
            break;
        case "split":
            echo implode(" ", splitString($inputString, "/./")[0]);
            break;
        case "hash":
            echo toHashString($inputString);
            break;
        case "shuffle":
            echo shuffleString($inputString);
            break;
    }
}

?>