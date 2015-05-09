<?php

if (isset($_GET['topic-id'])){
    $topic = $topicsService->getTopicById($_GET['topic-id']);

    if (!$topic){
        header("Location: index.php?page=error?error=The desired topic doesn't exist.");
        die();
    }

    $author = $userService->getUserById($topic->getAuthorId());
    $topicsService->increaseViews($topic->getId());

} else {
    header("Location: index.php?page=error?error=The desired topic doesn't exist.");
}

if (isset($_POST['like'])){
    $topicsService->increaseRating($topic->getId());
    echo "<script>window.location = window.location</script>";
} else if (isset($_POST['hate'])){
    $topicsService->decreaseRating($topic->getId());
    echo "<script>window.location = window.location</script>";
}

?>

<link rel="stylesheet" href="./styles/topic.css"/>
<main id="wrapper">

    <section class="topic-wrapper">
        <section class="topic-post">
            <div class="post-header">
                <img src="./images/default-user-avatar.png" class="user-avatar"/>
                <div class="post-info">
                    <span class="post-title"><?php echo $topic->getTitle()?></span>
                    <span class="post-stats">By <strong class="answer-username"><?php echo $author->getUsername()?></strong> on <?php echo $topic->getDate()?>. Views:<strong><?php echo " " . $topic->getViews()?></strong></span>
                </div>
                <div class="vote-controls">
                    <form method="post">
                        <input type="submit" name="like" value="&#x25b2;" id="likeBtn"/>
                        <span><?php echo $topic->getRating()?></span>
                        <input type="submit" name="hate" value="&#x25bc;" id="hateBtn"/>
                    </form>
                </div>
            </div>
            <div class="post-content"><?php echo nl2br($topic->getContent())?></div>
        </section>

        <!--<section class="topic-post">
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
        </section>-->
    </section>

    <?php

    if ($user){ ?>
        <span class="or-reg" style="border: none; padding: 0">Have anything to say? Add a new reply now</span>
        <section class="add-reply">
            <form method="post">
                <textarea name="userReply" id="userReply"></textarea>
                <input type="submit" value="Reply" id="replyBtn" name="replyBtn"/>
            </form>
        </section>
    <?php } else { ?>
        <span class="or-reg" style="border: none; padding: 0">Have anything to say? <a href="index.php?page=login" style="color: lightskyblue">Log in or register now</a> to add a reply</span>
    <?php }?>


</main>
<script>
    if (document.querySelector('#userReply'))
        CKEDITOR.replace('userReply');
</script>
