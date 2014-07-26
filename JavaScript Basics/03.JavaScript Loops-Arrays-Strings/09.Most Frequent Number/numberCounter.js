function findMostFreqNum (arr) {
	var mostFreqNum = arr[i];
	var curMostFreqNum = arr[i];
	
	var times = 0, curTimes = 0;;

	for (var i = 0; i < arr.length; i++){
		for (var k = 0; k < arr.length; k++){
			if (arr[i] == arr[k]){
				curMostFreqNum = arr[i];
				curTimes++;
			}
			if (times < curTimes){
				times = curTimes;
				mostFreqNum = curMostFreqNum;
			}
		}
		curTimes = 0;
	}
	return mostFreqNum + " (" + times + " times)";
}

console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
//console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
//console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));
