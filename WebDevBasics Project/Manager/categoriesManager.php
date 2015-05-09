<?php
require_once('config.php');
require_once('Models/Category.php');

class CategoryManager{
    private $pdo;

    function __construct() {
        $this->pdo = new PDO('mysql:host=localhost;dbname=softuni_forum;charset=utf8', DATABASE_USER);
        $this->pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }

    function createCategory(Category $category){
        $query = $this->pdo->prepare("INSERT INTO categories (name) VALUES (:name)");
        $query -> bindParam(':name', $category->getName());
        $query->execute();
    }

    function getCategoryByName($name){
        $query = $this->pdo->prepare("SELECT *
                                          FROM categories
                                          WHERE name LIKE :name");
        $query->bindParam(':name', $name);
        $query->execute();

        $data = $query->fetch();
        if($data){
            return new Category($data);
        }
        return null;
    }

    function getCategoryById($id){
        $query = $this->pdo->prepare("SELECT *
                                          FROM categories
                                          WHERE name LIKE :name");
        $query->bindParam(':id', $id);
        $query->execute();

        $data = $query->fetch();
        if($data){
            return new Category($data);
        }
        return null;
    }

    function getCategories($limit){
        $query = $this->pdo->prepare("SELECT * FROM categories ORDER BY id DESC LIMIT " . $limit);
        $query->execute();

        $data = $query->fetchAll();
        if($data){
            return ($data);
        }
        return null;
    }

}

?>