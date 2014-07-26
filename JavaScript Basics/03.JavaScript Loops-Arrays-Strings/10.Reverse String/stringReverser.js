function reverseString (str) {
	var res = "";
	for (var i = str.length-1; i >= 0; i--){
		res += str[i];
	}	
	return res;
}

console.log(reverseString("sample"));
//console.log(reverseString("softUni"));
//console.log(reverseString("java script"));