<?php
session_start();
?>
<html>
<head>
    <title>CV Generator</title>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>
    <?php
    if (isset($_POST['firstName'])){
        $error = false;
        $namesPattern = '/^[A-za-z ]{2,20}$/';
        $emailPattern = '/^[^@]+@[^@]+\.[^@]+$/';
        $companyPattern = '/^[A-Za-z0-9 ]{2,20}$/';
        $datePattern = '/^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$/';
        $phonePattern = '/^(\+{0,}[\d- ]+)$/';

        if (!preg_match($namesPattern, $_POST['firstName'])){
            echo "<p class='error'>Invalid name</p>";
            $error = true;
        }

        if (!preg_match($namesPattern, $_POST['lastName'])){
            echo "<p class='error'>Invalid last name</p>";
            $error = true;
        }

        if (!preg_match($emailPattern, $_POST['email'])){
            echo "<p class='error'>Invalid email address</p>";
            $error = true;
        }

        if (!preg_match($companyPattern, $_POST['companyName'])){
            echo "<p class='error'>Invalid company name</p>";
            $error = true;
        }

        if (!preg_match($datePattern, $_POST['dateFrom']) || !preg_match($datePattern, $_POST['dateTo'])){
            echo "<p class='error'>Invalid date/dates</p>";
            $error = true;
        }

        if (!preg_match($phonePattern, $_POST['phoneNumber'])){
            echo "<p class='error'>Invalid phone number</p>";
            $error = true;
        }

        if ($error == false) {
            $_SESSION = $_POST;
            header("location: CV Result.php");
        }
        $error = false;
    }
    ?>
    <form action="" method="post">
        <fieldset>
            <legend>Personal Information</legend>
            <input type="text" name="firstName" placeholder="First name..." required/><br/>
            <input type="text" name="lastName" placeholder="Last name..." required/><br/>
            <input type="text" name="email" placeholder="Email..." required/><br/>
            <input type="text" name="phoneNumber" placeholder="Phone number..." required/><br/>
            <label for="male">Male</label><input id="male" type="radio" name="gender" value="Male" required />
            <label for="female">Female</label><input id="female" type="radio" name="gender" value="Female"/><br/>
            Birth Date
            <input type="text" name="bDate" placeholder="dd/mm/yyyy" required/><br/>
            Nationality
            <select name="nationality">
                <option value="Bulgarian">Bulgarian</option>
                <option value="American">American</option>
                <option value="Martian">Martian</option>
            </select>
        </fieldset>

        <fieldset>
            <legend>Last Work Position</legend>
            Company Name <input type="text" name="companyName" placeholder="dd/mm/yyyy"/><br/>
            From <input type="text" name="dateFrom" placeholder="dd/mm/yyyy"/><br/>
            To <input type="text" name="dateTo" placeholder="dd/mm/yyyy"/>
        </fieldset>

        <fieldset id="pcSkills">
            <legend>Computer Skills</legend>
            <div id="pcLanguages">
                <div id="languageContainer1">
                    <input type="text" name="languages[]" placeholder="Language here..."/>
                    <select name="languageLevels[]">
                        <option value="Beginner">Beginner</option>
                        <option value="Intermediate">Intermediate</option>
                        <option value="Programmer">Programmer</option>
                        <option value="Ninja">Ninja</option>
                    </select>
                </div>
            </div>

            <input type="button" value="Add Language" onclick="addLanguage('pc')"/>
            <input type="button" value="Remove Language" onclick="removeLanguage('pc')">
        </fieldset>

        <fieldset id="otherSkills">
            <legend>Other Skills</legend>
            <div id="spokenLanguages">
                <div id="spokenLanguageContainer1">
                    <input type="text" name="spokenLanguages[]" placeholder="Language here..."/>
                    <select name="spokenLanguageComper[]">
                        <option value="Comprehension">-Comprehension-</option>
                        <option value="Beginner">Beginner</option>
                        <option value="Intermediate">Intermediate</option>
                        <option value="Advanced">Advanced</option>
                    </select>

                    <select name="spokenLanguageReading[]">
                        <option value="Reading">-Reading-</option>
                        <option value="Beginner">Beginner</option>
                        <option value="Intermediate">Intermediate</option>
                        <option value="Advanced">Advanced</option>
                    </select>

                    <select name="spokenLanguageWrite[]">
                        <option value="Writing">-Writing-</option>
                        <option value="Beginner">Beginner</option>
                        <option value="Intermediate">Intermediate</option>
                        <option value="Advanced">Advanced</option>
                    </select>
                </div>
            </div>

            <input type="button" value="Add Language" onclick="addLanguage('spoken')"/>
            <input type="button" value="Remove Language" onclick="removeLanguage('spoken')"><br/>
            Driver's Licence <br/>
            <label for="catB">B</label><input id="catB" type="radio" name="categoryLicence" value="B" required/>
            <label for="catA">A</label><input id="catA" type="radio" name="categoryLicence" value="A"/>
            <label for="catC">C</label><input id="catC" type="radio" name="categoryLicence" value="C"/>
            <label for="catNone">None</label><input id="catNone" type="radio" name="categoryLicence" value="None"/>
        </fieldset>
        <input type="submit" value="Generate CV"/>
    </form>
    <script src="script.js"></script>
</body>
</html>