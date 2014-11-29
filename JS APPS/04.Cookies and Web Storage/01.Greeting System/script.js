function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for(var i=0; i<ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0)==' ') c = c.substring(1);
        if (c.indexOf(name) != -1) return c.substring(name.length,c.length);
    }
    return "";
}

function setViewsCookie(views){
    document.cookie = "sessionViews=" + views;
}

function showVisitDetails(){
    setViewsCookie(Number(getCookie('sessionViews'))+1);
    $("#sessionVisits").text("Total Visits: " + getCookie("sessionViews"));
    localStorage.setItem("localVisits", Number(localStorage.getItem('localVisits'))+1);
    $("#localVisits")
        .text("LocalStorage Visits: " + localStorage.getItem('localVisits'))
        .prepend("<h2>Hi " + localStorage.getItem("name") + "!</h2>")
        .prepend("<button id='clearLocalCounter'>Reset localStorage counter</button>")
        .prepend("<button id='clearCookieCounter'>Reset cookie counter</button>");

    $("#clearLocalCounter").on('click', function(){
        localStorage.removeItem("localVisits");
        localStorage.removeItem("name");
    });

    $("#clearCookieCounter").on('click', function(){
        setViewsCookie(0);
    });
}