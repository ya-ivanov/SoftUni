function findPalindromes(text) {
	text = removeAll([".", ",", "-"], text);
	var arr = text.toLowerCase().split(' ');
	for (var i = 0; i < arr.length; i++){
		if (arr[i] == reverseString(arr[i])){
			console.log(arr[i]);
		}
	}
}

function removeAll (charToRemove, src) {               // Napisah funkciqta poneje ne namerih alternativa,
	if (typeof(charToRemove) == 'string'){             //na split, po pove4e ot edin char-a, i zatova koeto znam 4e ne mi trqbva go maham predvaritelno.
		while (src.indexOf(charToRemove) > -1){
			src = src.replace(charToRemove, "");
		}
	}
	else if (typeof(charToRemove) == 'object'){
		for (var i = 0; i < charToRemove.length; i++){
			while (src.indexOf(charToRemove[i]) > -1){
				src = src.replace(charToRemove[i], "");
			}
		}
	}	
	return src;
}

function reverseString (str) {
	var res = "";
	for (var i = str.length-1; i >= 0; i--){
		res += str[i];
	}	
	return res;
}

findPalindromes('There is a man, his name was Bob.');