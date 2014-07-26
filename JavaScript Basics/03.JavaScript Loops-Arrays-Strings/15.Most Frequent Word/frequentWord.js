function findMostFreqWord(text) {
	var arr = removeAll([".", ","], text).split(' ');
	var mostFreqWord = arr[i];
	var curMostFreqWord = arr[i];
	
	var times = 0, curTimes = 0;;

	for (var i = 0; i < arr.length; i++){
		for (var k = 0; k < arr.length; k++){
			if (arr[i] == arr[k]){
				curMostFreqWord = arr[i];
				curTimes++;
			}
			if (times < curTimes){
				times = curTimes;
				mostFreqWord = curMostFreqWord;
			}
		}
		curTimes = 0;
	}
	return (mostFreqWord + " (" + times + " times)");
}

function removeAll (charToRemove, src) {               
	if (typeof(charToRemove) == 'string'){          
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

console.log(findMostFreqWord('in the middle of the night'));
//console.log(findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.'));
