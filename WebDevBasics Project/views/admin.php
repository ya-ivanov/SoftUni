<?php

if (!$user || !$user->isAdmin()){
    header("Location: index.php");
}

?>

<main id="wrapper">
    <section class="category-holder">
        <div class="category-title">Create category</div>
        <div class="category-information">
            <div class="category" style="height: auto; padding: 10px;">
                <form method="post">
                    <input type="text" class="fancyInput" placeholder="Category name" name="name" style="display:inline-block;width: 40%; height: 30px; margin: 0"/>
                    <input type="text" class="fancyInput" placeholder="Category description" name="description" style="display:inline-block;width: 40%; height: 30px; margin: 0"/>
                    <input type="submit" name="createCategory" value="Create" class="button" style="width: 17%; height: 30px;"/>
                </form>
            </div>
        </div>
    </section>

    <section class="category-holder">
        <div class="category-title">Delete category</div>
        <div class="category-information">
            <div class="category" style="height: auto; padding: 10px;">
                <form method="post">
                    <select class="fancySelect" name="categoryToDelete" style="display:inline-block;width: 80%; height: 30px; margin: 0;  padding: 0px 10px;">

                        <?php
                        $categories = $categoryService->getCategories();

                        foreach ($categories as $category){
                            echo "<option value=" .  $category['id'] . ">" . $category['name'] . "</option>";
                        }
                        ?>

                    </select>
                    <input type="submit" name="deleteCategory" value="Delete" class="button" style="width: 17%; height: 30px;"/>
                </form>
            </div>
        </div>
    </section>
</main>
