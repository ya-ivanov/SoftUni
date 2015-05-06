<!DOCTYPE html>
<html>
    <head>
        <title>Log In</title>
        <meta charset="utf-8"/>
        <link href="//fonts.googleapis.com/css?family=Asap:700" rel="stylesheet" type="text/css">
        <link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:400,600" rel="stylesheet" type="text/css">
        <link rel="stylesheet" href="./styles/styles.css"/>
        <link rel="stylesheet" href="./styles/logIn.css"/>
        <link rel="stylesheet" href="./styles/media-queries.css"/>
    </head>
    <body>
        <?php require_once('./views/header.php')?>

        <main id="wrapper">
            <form method="post">
                <div id="logIn">
                    <fieldset>
                        <legend>Log Into your account</legend>
                        <input type="text" placeholder="Username"/>
                        <input type="password" placeholder="Password"/>
                        <input type="submit" value="Log me in" id="logInButton"/>
                    </fieldset>
                </div>
            </form>
            <span class="or-reg">You don't have an account?</span>
            <form method="post">
                <div id="register">
                    <fieldset>
                        <legend>Create a new one</legend>
                        <input type="text" placeholder="Username"/>
                        <input type="text" placeholder="Email address"/>
                        <input type="password" placeholder="Password"/>
                        <input type="password" placeholder="Repeat password"/>
                        <input type="submit" value="Register" id="registerButton"/>
                    </fieldset>
                </div>
            </form>
        </main>


        <?php require_once('./views/footer.php')?>

        <script src="./scripts/script.js"></script>
    </body>
</html>