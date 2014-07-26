function toWord(digit){
	console.log(digit);
	switch(Number(digit)){
		case 1: return 'one'
		case 2: return 'two'
		case 3: return 'three'
		case 4: return 'four'
		case 5: return 'five'
		case 6: return 'six'
		case 7: return 'seven'
		case 8: return 'eight'
		case 9: return 'nine'
	}
}

function lastDigitAsText (number) {
	return String(number).charAt(number.length-1);
}

console.log(toWord(lastDigitAsText(6)));