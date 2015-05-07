CREATE TABLE "answers" ("id" INTEGER PRIMARY KEY AUTOINCREMENT, "topic_id" INTEGER, "rating" INTEGER DEFAULT 0, "content" TEXT NOT NULL DEFAULT 0, "author_id" INTEGER, "date" DATE NOT NULL DEFAULT 0);
CREATE TABLE "categories" ("id" INTEGER PRIMARY KEY AUTOINCREMENT, "name" TEXT NOT NULL);
CREATE TABLE "topics" ("id" INTEGER PRIMARY KEY AUTOINCREMENT, "title" TEXT NOT NULL, "url_title" TEXT NOT NULL, "content" TEXT NOT NULL, "author_id" INTEGER NOT NULL, "views" INTEGER DEFAULT 0, "rating" INTEGER DEFAULT 0, "answers" INTEGER DEFAULT 0, "category_id" INTEGER NOT NULL DEFAULT 0, "date" DATE NOT NULL DEFAULT 0);
CREATE TABLE "users" ("id" INTEGER PRIMARY KEY AUTOINCREMENT, "username" TEXT NOT NULL UNIQUE, "email" TEXT NOT NULL UNIQUE, "password" TEXT NOT NULL, "is_admin" BOOLEAN DEFAULT false);
