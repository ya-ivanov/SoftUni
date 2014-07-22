function digitChecker (num) {
	if (num.toString().charAt(num.toString().length-3) == "3"){
		return true;
	}
	return false;
}

console.log(digitChecker(1235));
console.log(digitChecker(25368));
console.log(digitChecker(123456));