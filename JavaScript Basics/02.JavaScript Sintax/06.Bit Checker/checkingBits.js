function bitChecker (num) {
	var bit = num.toString(2);
	if (bit.charAt(bit.length - 4) == '1')
		return true;

	return false;
}
console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));