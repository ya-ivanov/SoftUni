function findLargestSumOfDigits (numbers) {
	var maxSum = 0, curSum = 0, res;

	if (typeof(numbers) == 'object'){
		for (var i = 0; i < numbers.length; i++){
			numbers[i] = String(numbers[i]).replace("-", "");
			for (var j = 0; j < String(numbers[i]).length; j++){
				curSum += Number(numbers[i][j]);
			}
			if (curSum >= maxSum){
				maxSum = curSum;
				res = numbers[i];
			}
			curSum = 0;
		}
		return String(res).length > 1 ? res : "undefined";
	} else {
		return "undefined";
	}
}

console.log(findLargestSumOfDigits([5, 10, 15, 111]));
console.log(findLargestSumOfDigits([33, 44, -99, 0, 20]));
console.log(findLargestSumOfDigits(['hello']));
console.log(findLargestSumOfDigits([5, 3.3]));