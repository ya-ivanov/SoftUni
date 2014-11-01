function argumentless(){
    console.log('Number of arguments: ' + arguments.length);
    for (var i = 0; i < arguments.length; i++){
        console.log('Argument : ' + arguments[i] + " with type " + typeof(arguments[i]));
    }
    console.log("\n");
}

argumentless(1, "3", 3);
//argumentless(1, "3", 3, 4, 6, 2, null);
//argumentless({'name': 'Go6o', 'age': 64});
//argumentless([1, 5, 9, 6]);

//argumentless.call(null, 33, "Something", 9);
//argumentless.apply(null, [33, "Something", 8]);