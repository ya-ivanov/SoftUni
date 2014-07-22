function isPrime (num) {
	var times = 0;
	for (var i = 0; i < num +1 ; i++) {
		if (Number(num) % i == 0){
			times++;
		}
	}

	if (times != 2){
		return false;
	}

	return true;
}

console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));
console.log(isPrime(461));
console.log(isPrime(758));
console.log(isPrime(881));