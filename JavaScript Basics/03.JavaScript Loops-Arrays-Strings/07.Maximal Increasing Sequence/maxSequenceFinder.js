function findMaxSequence (arr) {
	var maxSeq = [], curMaxSeq = [];

	for (var i = 1; i <= arr.length; i++){
		if (arr[i] > arr[i-1])
			curMaxSeq.push(arr[i-1]);		
		else{
			curMaxSeq.push(arr[i-1]);
			if (curMaxSeq.length >= maxSeq.length){
				maxSeq = curMaxSeq;
			}
			curMaxSeq = [];
		}		
	}
	return maxSeq.length > 1 ? maxSeq : "no";
}

console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
//console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
//console.log(findMaxSequence([3, 2, 1]));