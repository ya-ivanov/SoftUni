function compareChars (charArrs) {
	if (charArrs[0].length != charArrs[1].length){
		console.log("Not Equal");
		return;
	}
	else{
		for (var i = 0; i < charArrs[0].length; i++){
			if (charArrs[0][i] != charArrs[1][i]){
				console.log("Not Equal");
				return;
			}
		}
	}
	console.log("Equal");
}

compareChars([['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'] , ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']]);
compareChars([['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']]);
compareChars([['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']]);