var wowsole = function() {

    function writeLine(){
        console.log(reformatString(arguments));
    }

    function writeError(){
        console.log(reformatString(arguments))
    }

    function writeWarning(){
        console.log(reformatString(arguments))
    }

    function reformatString(args){
        var str = args[0];
        for (var i = 0; args.length; i++){
            if (str.indexOf('{' + i + '}') != -1){
                if (typeof(args[i+1]) != 'undefined'){
                    str = str.replace(('{' + i + '}'), args[i+1].toString());
                }
            } else {
                break;
            }
        }
        return str;
    }

    var self = {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    };

    return self;
}();



// Some examples

// wowsole.writeError("Don't divide by zero...")
// wowsole.writeLine("Yay {0} {1} {2}", "broo", "waaat", "heeyyyy");
// wowsole.writeLine("Message: hi");
// wowsole.writeWarning("Warning: {0}", "You may die, if not careful...!");
// wowsole.writeLine("placeholders: {0} {1} {2}", 'edno', 'dve', 'tri');
// wowsole.writeLine("placeholders: {2} {0} {1}", 'edno', 'dve', 'tri');