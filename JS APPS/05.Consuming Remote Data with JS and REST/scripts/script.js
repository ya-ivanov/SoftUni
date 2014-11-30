alert("Each field(title, author, isbn) is editable.\n\n" +
    "Just write whatever you want, and then tap somewhere outside the field to save.\n\n" +
    "Double tap on a book, until it changes to red, to delete it.\n\n" +
    "Please, if you delete a book, add a new one :). Thanks");

$("#newBookBtn").on('click', function(){
    $('.books').append
        ('<section class="book">' +
            '<textarea class="bookTitle" id="newBookTitle">Book title here</textarea>'+
            '<textarea class="bookAuthor" id="newBookAuthor">Author here</textarea>' +
            '<textarea class="bookIsbn" id="newBookISBN">ISBN here</textarea>' +
        '</section>');
    $("#newBookBtn").hide();
    $("#saveNewBook").show();
});

$("#saveNewBook").on('click', function(){
    var title = $("#newBookTitle").val();
    var author = $("#newBookAuthor").val();
    var isbn = $("#newBookISBN").val();

    addNewBook(title, author, isbn);
    $("#newBookBtn").show();
    $("#saveNewBook").hide();
});

$.ajaxSetup({
    headers: {
        "X-Parse-Application-Id": "fzyW2A0jl2uJnKh779IMaUIIvo9g0zH7dUBX3JKQ",
        "X-Parse-REST-API-Key": "rKaQFlPgTr1wEjuI2vxbtVaxQ7hl112hHPGVy4Fc"
    }
});

function getBooks(){
    $.ajax({
        method: "GET",
        url: encodeURI("https://api.parse.com/1/classes/Book?order=-createdAt"),
        success: showBooks,
        error: databaseError
    });
}

function addNewBook(title, author, isbn){
    $.ajax({
        method: "POST",
        url: "https://api.parse.com/1/classes/Book",
        data: JSON.stringify(
            {
                'Title': title,
                'Author': author,
                'isbn':isbn
            }
        ),
        success: getBooks,
        contentType: "application/json",
        error: databaseError
    });
}

function showBooks(data){
    $('.books').html("");
    data.results.forEach(function(item){
        $('.books').append
                ('<section class="book" id="' + item.objectId + '">' +
                    '<textarea spellcheck="false" class="bookTitle" id="title-' + htmlEntities(item.objectId) + '">' + item.Title + '</textarea>'+
                    '<textarea spellcheck="false" class="bookAuthor" id="author-' + htmlEntities(item.objectId) + '">' + item.Author + '</textarea>' +
                    '<textarea spellcheck="false" class="bookIsbn" id="isbn-' + htmlEntities(item.objectId) + '">' + item.isbn + '</textarea>' +
                '</section>');

        $("#" + item.objectId).on("dblclick", function(){
            $(this).css("background", "rgb(255, 79, 79)");
            var toDelete = confirm("Are you sure, that you want to delete the book: " + item.Title + "? This cannot be undone!");
            if (toDelete){
                deleteBook(item.objectId);
            } else {
                $("#" + item.objectId).css("background", "white");
            }
        });

        $("#title-" + item.objectId).on("change", function(){
            editBookTitle(this.getAttribute('id').split('-')[1], $(this).val());
        });

        $("#author-" + item.objectId).on("change", function(){
            editBookAuthor(this.getAttribute('id').split('-')[1], $(this).val());
        });

        $("#isbn-" + item.objectId).on("change", function(){
            editBookIsbn(this.getAttribute('id').split('-')[1], $(this).val());
        });
    });
}

function editBookTitle(objectId, content){
    if (!content){
        alert('Please Enter a valid Title for the book');
        return;
    }

    $.ajax({
        method: 'PUT',
        url: 'https://api.parse.com/1/classes/Book/' + objectId,
        data: JSON.stringify({'Title':content}),
        contentType: "application/json",
        success: function(){ alert("Book title saved");},
        error: databaseError
    });
}

function editBookAuthor(objectId, content){
    if (!content){
        alert('Please Enter a valid Author for the book');
        return;
    }

    $.ajax({
        method: 'PUT',
        url: 'https://api.parse.com/1/classes/Book/' + objectId,
        data: JSON.stringify({'Author':content}),
        contentType: "application/json",
        success: function(){ alert("Book author saved");},
        error: databaseError
    });
}

function editBookIsbn(objectId, content){
    if (!content){
        alert('Please Enter a valid ISBN for the book');
        return;
    }

    $.ajax({
        method: 'PUT',
        url: 'https://api.parse.com/1/classes/Book/' + objectId,
        data: JSON.stringify({'isbn':content}),
        contentType: "application/json",
        success: function(){ alert("Book ISBN saved");},
        error: databaseError
    });
}

function deleteBook(id){
    $.ajax({
        method: 'DELETE',
        url: 'https://api.parse.com/1/classes/Book/' + id,
        success: getBooks,
        error: databaseError
    });
}

function databaseError(err){
    alert('Database connection error. See console');
    console.log(err);
}

function htmlEntities(str) {
    return String(str).replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;').replace(/"/g, '&quot;');
}

getBooks();