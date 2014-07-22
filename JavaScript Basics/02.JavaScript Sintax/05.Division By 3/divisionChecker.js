function divisionBy3 (num) {
	var sum = 0;
	for (var i = 0; i < num.toString().length ; i++) {
		sum += Number(num.toString().charAt(i));
	}

	if (sum % 3 == 0){
		return "the number is divided by 3 without remainder";
	}
	return "the number is not divided by 3 without remainder";
}

console.log(divisionBy3(12));
console.log(divisionBy3(188));
console.log(divisionBy3(591));