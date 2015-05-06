<!DOCTYPE html>
<html>
    <head>
        <title>Topic</title>
        <meta charset="utf-8"/>
        <link href="//fonts.googleapis.com/css?family=Asap:700" rel="stylesheet" type="text/css">
        <link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:400,600" rel="stylesheet" type="text/css">
        <link rel="stylesheet" href="./styles/styles.css"/>
        <link rel="stylesheet" href="./styles/topic.css"/>
        <link rel="stylesheet" href="./styles/media-queries.css"/>

        <script src="./ckeditor/ckeditor.js"></script>
    </head>
    <body>

        <?php require_once('./views/header.php')?>

        <main id="wrapper">

            <section class="topic-wrapper">
                <section class="topic-post">
                    <div class="post-header">
                        <img src="./images/default-user-avatar.png" class="user-avatar"/>
                        <div class="post-info">
                            <span class="post-title">Testing this out</span>
                            <span class="post-stats">By <strong class="answer-username">mrtest</strong> on 26 Nov 2014, 07:22</span>
                        </div>
                    </div>
                    <div class="post-content">
                        Hi mrtest,  <br><br>

                        Thanks for testing :-)<br><br>

                        Here's a few things for you.<br><br>

                        -The SiteSplat community forum has around 100 modifications and are all FREE. They are all the most used on phpBB like the gallery etc, and I port MODs that are useful, supported by its developers and possibly well coded. I take requests as well. You can also find premium addons that are developed by me and are unique and fun to use. For example the Ajax Like/dislike system you see here or a Facebook Profile Wall system to mention another one.<br><br>

                        Regarding the image above, that is handled by a phpBB MOD and you can adjust the settings. here there are just basic settings applied.<br><br>

                        Youtube and Vimeo videos are responsive as well and you can decide between 3 different BBcode choices to use 4:9, 16:9 or full post width. : Get them here: http://www.sitesplat.com/phpBB3/viewforum.php?f=14<br><br>

                        -The Recent topics you see below is well over $200 and its included for free. ;-) The speed grade of this theme is 98%. I use best code practices with the latest web technologies and I know phpBB inside out as I've been doing custom development for many, many moons now. Support response time is within 6 hours and sometimes within minutes.<br><br>

                        -The theme is built from scratch and with the bootstrap framework . All the other phpBB themes on Themeforest are sadly some HTML/CSS soup coded by amateurs and obviously have very limited knowledge in the field. They also claim to use Bootstrap but its unfortunate that they make the general public fools with their marketing keywords. My themes are the only ones to integrate fully bootstrap.<br><br>

                        Finally there is an extensive documentation included in the theme and covers, basic and advanced customization features.<br><br>

                        Let me know if you have any other questions!<br><br>
                        Cheers!<br><br>
                    </div>
                </section>

                <section class="topic-post">
                    <div class="post-header">
                        <img src="./images/default-user-avatar.png" class="user-avatar"/>
                        <div class="post-info">
                            <span class="post-title">Testing this out</span>
                            <span class="post-stats">By <strong class="answer-username">mrtest</strong> on 26 Nov 2014, 07:22</span>
                        </div>
                    </div>
                    <div class="post-content">
                        Hi mrtest,  <br><br>

                        I completely agree with you. Good luck.
                    </div>
                </section>
            </section>

            <span class="or-reg" style="border: none; padding: 0">Have anything to say? Add a new reply now</span>

            <section class="add-reply">
                <form method="post">
                    <textarea name="userReply" id="userReply"></textarea>
                    <input type="submit" value="Reply" id="replyBtn" name="replyBtn"/>
                </form>
            </section>
        </main>

        <?php require_once('./views/footer.php')?>

        <script>
            CKEDITOR.replace('userReply');
        </script>
        <script src="./scripts/script.js"></script>
    </body>
</html>