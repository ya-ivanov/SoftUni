<header>
    <div id="nav-header">
        <div class="nav-wrapper">
            <h2>Topico</h2>
            <ul class="nav">
                <li><a href="./index.php?page=main">Home</a></li>
                <li>Forum</li>
                <li>About</li>
            </ul>
            <ul class="user-options">
                <?php
                    if ($user){ ?>
                        <li><?php echo $user->getFirstName() . " " . $user->getLastName() . "(" . $user->getUsername() . ")"?></li>
                        <li class="drop-down-item">Options &#x25bc;
                            <ul class="drop-down-menu">
                                <li>Profile</li>
                                <li><a href="index.php?page=logout">Exit</a></li>
                            </ul>
                        </li>
                <?php
                    } else {?>
                        <li>Create account</li>
                        <li><a href="./index.php?page=login">Log in</a></li>
                <?php
                    }
                ?>

            </ul>
        </div>
    </div>
    <div class="preview-header">
        <div>
            <h2>SoftUni Forum Project</h2>
            <span>A simple forum created with html, css, js, php & mySql, assigned from SoftUni...</span>
        </div>
    </div>
</header>