<link rel="stylesheet" href="./styles/logIn.css"/>
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