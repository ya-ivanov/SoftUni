var interval;
var timePast = 0;
var points = 0;

var correctAnswers = ["spiderman", "doctorWho", "nobodyCaresAboutYou"];

$("#submitBtn").on('click', validateResults);

(function addEventListeners(){
    $("input[name=answersQuestion1]").on("click", function(){
        localStorage.setItem("question-1-answer", $("input[name=answersQuestion1]:checked").val());
        localStorage.setItem("submitted", 'false');
    });

    $("input[name=answersQuestion2]").on("click", function(){
        localStorage.setItem("question-2-answer", $("input[name=answersQuestion2]:checked").val());
        localStorage.setItem("submitted", 'false');
    });

    $("input[name=answersQuestion3]").on("click", function(){
        localStorage.setItem("question-3-answer", $("input[name=answersQuestion3]:checked").val());
        localStorage.setItem("submitted", 'false');
    });
})();

(function() {
    interval = setInterval(updateSeconds, 1000)
})();

function updateSeconds() {
    if (timePast <= (5*60)-1)
        timePast++;

    else {
        clearInterval(interval);
        alert("Time's up!");
        validateResults();
    }
}

(function(){
    var answer1 = localStorage.getItem("question-1-answer");
    var answer2 = localStorage.getItem("question-2-answer");
    var answer3 = localStorage.getItem("question-3-answer");
    var answers = [answer1, answer2, answer3];

    answers.forEach(function(item, index){
        if (item != null){
            $("input[value=" + (item) + "]").attr("checked", "checked");
        }
    });
    if (localStorage.getItem('submitted') == 'true'){
        validateResults();
    }
})();


function validateResults(){
    localStorage.setItem("submitted", 'true');
    points = 0;
    for (var i = 0; i < 3; i++){
        if ($("input[name=answersQuestion" + (i+1) + "]:checked").val() == correctAnswers[i]){
            points++;
        }
    }
    $("#results").text("Correct answers: " + points).fadeIn(1000).delay(1000).fadeOut(1000);
}