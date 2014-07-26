function printNumbers (n) {
	var res = "";
	for (var i = 0; i <= n; i++){
		if (i % 4 != 0 && i % 5 != 0)
			res += i + ", ";
	}
	return res === "" ? "no" : res;
}

console.log(printNumbers(20));
//console.log(printNumbers(-5));
//console.log(printNumbers(13));