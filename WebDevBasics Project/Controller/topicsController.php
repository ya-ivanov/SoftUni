<?php

require_once('Service/topicsService.php');

$topicsService = new TopicsService();

if (isset($_GET['page']) && $_GET['page'] == 'main'){
    $mostPopularTopics = $topicsService->getMostPopularTopics();
    $latestTopics = $topicsService->getTopics(3);
}

if (isset($_POST['addTopicBtn'])){
    try{
        $topic = new Topic();
        $topic->setTitle($_POST['title']);
        $topic->setContent($_POST['topic-content']);
        $topic->setCategoryId($_POST['category']);
        $topic->setAuthorId($user->getId());

        $topicsService->createTopic($topic);

        header("Location: index.php?page=main");
    }
    catch(Exception $ex){
        $error = $ex->getMessage();
        header("Location: index.php?page=error&error=".$error);
    }
}