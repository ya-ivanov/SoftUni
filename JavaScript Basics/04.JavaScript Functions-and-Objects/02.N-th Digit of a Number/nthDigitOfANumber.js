function findNthDigit (arr) {
	arr[1] = String(arr[1]).replace('.', "");
	return arr[1].length >= arr[0] ? String(arr[1]).charAt(arr[1].length-arr[0]) : "The number doesn’t have " + arr[0] + " digits";
}

console.log(findNthDigit([1, 6]));
console.log(findNthDigit([2, -55]));
console.log(findNthDigit([6, 923456]));
console.log(findNthDigit([3, 1451.78]));
console.log(findNthDigit([6, 888.88]));