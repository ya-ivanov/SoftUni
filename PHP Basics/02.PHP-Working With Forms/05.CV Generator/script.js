var nextPCLanguageID = 2;
var nextSpokenLanguageID = 2;

var pcLanguages = document.getElementById("pcLanguages");
var spokenLanguages = document.getElementById("spokenLanguages");

String.prototype.toDOM=function(){
    var d=document
        ,i
        ,a=d.createElement("div")
        ,b=d.createDocumentFragment();
    a.innerHTML=this;
    while(i=a.firstChild)b.appendChild(i);
    return b;
};

function addLanguage(addTo){
    if(addTo == 'pc'){
        var innerHTMLStr = ('<div id=' + "'languageContainer" + nextPCLanguageID + "'" + '><input type="text" name="languages[]" placeholder="Language here..."/> <select name="languageLevels[]">    <option value="Begginer">Begginer</option>    <option value="Intermidiate">Intermidiate</option>    <option value="Programmer">Programmer</option>    <option value="Ninja">Ninja</option></select>  </div>').toDOM();
        pcLanguages.appendChild(innerHTMLStr);
        nextPCLanguageID++;
    } else{
        var innerHTMLStr = ('<div id=' + "'spokenLanguageContainer" + nextSpokenLanguageID + "'" + '><input type="text" name="spokenLanguages[]" placeholder="Language here..."/> <select name="spokenLanguageComper[]">        <option value="Comprehension">-Comprehension-</option>        <option value="Beginner">Beginner</option>        <option value="Intermediate">Intermediate</option>        <option value="Advanced">Advanced</option>    </select> <select name="spokenLanguageReading[]">        <option value="Comprehension">-Reading-</option>        <option value="Beginner">Beginner</option>        <option value="Intermediate">Intermediate</option>        <option value="Advanced">Advanced</option>    </select> <select name="spokenLanguageWrite[]">        <option value="Comprehension">-Writing-</option>        <option value="Beginner">Beginner</option>        <option value="Intermediate">Intermediate</option>        <option value="Advanced">Advanced</option>    </select>  </div>').toDOM();
        spokenLanguages.appendChild(innerHTMLStr);
        nextSpokenLanguageID++;
    }

}

function removeLanguage(removeFrom){
    if (removeFrom == 'pc'){
        pcLanguages.removeChild(document.getElementById("languageContainer" + --nextPCLanguageID));
    } else {
        spokenLanguages.removeChild(document.getElementById("spokenLanguageContainer" + --nextSpokenLanguageID));
    }

}