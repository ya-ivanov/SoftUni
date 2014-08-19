<html>
<head>
    <title>CV RESULT</title>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>
    <?php
    session_start();
    if (isset($_SESSION['firstName'])){
        echo '<table><tr><th colspan="2">Personal Information</th></tr>';
        echo "<tr><td>First Name</td><td>" . $_SESSION['firstName'] . "</td></tr>";
        echo "<tr><td>Last Name</td><td>" . $_SESSION['lastName'] . "</td></tr>";
        echo "<tr><td>Email</td><td>" . $_SESSION['email'] . "</td></tr>";
        echo "<tr><td>Phone Number</td><td>" . $_SESSION['phoneNumber'] . "</td></tr>";
        echo "<tr><td>Gender</td><td>" . $_SESSION['gender'] . "</td></tr>";
        echo "<tr><td>Birth Date</td><td>" . $_SESSION['bDate'] . "</td></tr>";
        echo "<tr><td>Nationality</td><td>" . $_SESSION['nationality'] . "</td></tr>";
        echo "<tr><th colspan='2'>Last Work Position</th></tr>";
        echo "<tr><td>Company Name</td><td>" . $_SESSION['companyName'] . "</td></tr>";
        echo "<tr><td>From</td><td>" . $_SESSION['dateFrom'] . "</td></tr>";
        echo "<tr><td>To</td><td>" . $_SESSION['dateTo'] . "</td></tr>";
        echo "<tr><th colspan='2'>Computer Skills</th></tr>";
        echo "<tr><td>Programming Languages</td><td><table>";
        echo "<tr><td>Language</td><td>Skill Level</td></tr>";

        $curProgrammingLang = 0;
        foreach ($_SESSION['languages'] as $language){
            echo "<tr>";
            echo "<td>" . $language . "</td>";
            echo "<td>" . $_SESSION['languageLevels'][$curProgrammingLang] . "</td>";
            echo "</tr>";
            $curProgrammingLang++;
        }
        echo "</table></td>";

        echo "<tr><th colspan='2'>Other Skills</th></tr>";
        echo "<tr><td>Languages</td><td><table>";
        echo "<tr><th>Language</th><th>Comprehension</th><th>Reading</th><th>Writing</th></tr>";

        $curLang = 0;
        foreach ($_SESSION['spokenLanguages'] as $language){
            echo "<tr>";
            echo "<td>" . $language . "</td>";
            echo "<td>" . $_SESSION['spokenLanguageComper'][$curLang] . "</td>";
            echo "<td>" . $_SESSION['spokenLanguageReading'][$curLang] . "</td>";
            echo "<td>" . $_SESSION['spokenLanguageWrite'][$curLang] . "</td>";
            echo "</tr>";
            $curLang++;
        }
        echo "</table></td>";
        echo '</table>';

    }
    ?>
</body>
</html>


