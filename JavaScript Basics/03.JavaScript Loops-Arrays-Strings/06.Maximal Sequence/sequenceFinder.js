function findMaxSequence (arr) {
	var maxSeq = [], curMaxSeq = [];

	for (var i = 1; i <= arr.length; i++){
		if (arr[i] === arr[i-1])
			curMaxSeq.push(arr[i]);		
		else{
			curMaxSeq.push(arr[i-1]);
			if (curMaxSeq.length >= maxSeq.length){
				maxSeq = curMaxSeq;
			}
			curMaxSeq = [];
		}		
	}
	return maxSeq;
}

console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));