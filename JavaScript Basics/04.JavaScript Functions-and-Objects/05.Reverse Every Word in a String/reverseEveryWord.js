function reverseString (str) {
	var res = "";
	for (var i = str.length-1; i >= 0; i--){
		res += str[i];
	}	
	return res;
}

function reverseWordsInString (str) {
	var words = str.split(" ");
	var res = "";
	for (var word in words){
		res+= reverseString(words[word]) + " ";
	}
	return res;
}

console.log(reverseWordsInString('Hello, how are you.'));
console.log(reverseWordsInString("Life is pretty good, isn’t it?"));