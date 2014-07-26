function replaceSpaces (text) {
	while (text.indexOf(" ") > -1){
		text = text.replace(" ", "&nbsp;");
	}
	return text;
}

console.log(replaceSpaces("But you were living in another world tryin' to get your message through"))