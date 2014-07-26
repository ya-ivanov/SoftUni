function checkBrackets (expr) {
	var closed = true;
	for (var i = 0; i < expr.length; i++){
		if (expr[i] == '('){
			closed = false;
		} else if (expr[i] == ')' && closed == false){
			closed = true;
		}
	}

	return closed == true && count(')', expr) == count('(', expr) ? "correct" : "incorrect";
}

function count (char, where) {
	var count = 0;
	for (var  i = 0; i < where.length; i++){
		if (where[i] == char) 
			count++;
	}
	return count;
}

console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));