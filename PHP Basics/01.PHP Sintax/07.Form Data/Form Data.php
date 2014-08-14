<form action="" method="post">
    <input type="text" name="name" placeholder="Name..."/>
    <input type="text" name="age" placeholder="Age..."/><br/>

    <input type="radio" name="gender" value="Male" id="male"><label for="male">Male</label><br/>
    <input type="radio" name="gender" value="Female" id="female"/><label for="female">Female</label><br/>

    <input type="submit" value="Submit"/>
</form>

<?php

if (isset($_POST["name"])){
    $gender =  $_POST["gender"];
    echo "My name is " . $_POST['name'] . " and I am " .  $_POST['age'] . " years old. I am $gender";
}
?>