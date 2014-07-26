function createArray () {
	var arr = [];
	for (var i = 0; i < 20; i++){
		arr.push(i*5);
	}
	return arr;
}

var myArr = createArray();
for (var i = 0; i < myArr.length; i++) {
	console.log(myArr[i]);
}