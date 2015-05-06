<!DOCTYPE html>
<html>
    <head>
        <title>Create new Topic</title>
        <meta charset="utf-8"/>
        <link href="//fonts.googleapis.com/css?family=Asap:700" rel="stylesheet" type="text/css">
        <link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:400,600" rel="stylesheet" type="text/css">
        <link rel="stylesheet" href="./styles/styles.css"/>
        <link rel="stylesheet" href="./styles/new-topic.css"/>
        <link rel="stylesheet" href="./styles/media-queries.css"/>
        <script src="./ckeditor/ckeditor.js"></script>
    </head>
    <body>
        <?php require_once('./views/header.php')?>

        <main id="wrapper">
            <span class="or-reg" style="border: none; padding: 0;text-align: left; text-transform: uppercase; width: 70%; font-size: 25px">Post a new topic</span>
            <section class="new-topic">
                <form method="post" name="newTopic">
                    <input type="text" name="subject" id="topic-subject" placeholder="Subject..."/>

                    <span class="or-reg" style="border: none; padding: 0;text-align: left; text-transform: uppercase; width: 98%; font-size: 15px; margin: 0 auto">Content</span>
                    <textarea name="topic-content" id="topic-content"></textarea>

                    <select name="category" style="margin-top: 15px;">
                        <option>Category...</option>
                        <option value="cars">cars</option>
                    </select>

                    <div style="width: 98%; margin: 0 auto; text-align: right;">
                        <input type="submit" id="addTopicBtn"/>
                    </div>
                </form>
            </section>
        </main>

        <?php require_once('./views/footer.php')?>

        <script>
            CKEDITOR.replace('topic-content');
        </script>
        <script src="./scripts/script.js"></script>
    </body>
</html>