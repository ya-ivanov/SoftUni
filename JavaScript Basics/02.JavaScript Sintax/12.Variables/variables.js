function variableTypes (name, age, isMale, favFoods) {
	console.log("My Name: " + name + " //type is " + typeof(name));
	console.log("My age: " + age + " //type is " + typeof(age));
	console.log("I am male: " + isMale + " //type is " + typeof(isMale));
	console.log("My favourite foods are: ");

	for (var i = 0; i < favFoods.length; i++)
		console.log(favFoods[i] + ", ") ;	

	console.log("//type is " + typeof(favFoods));
}

variableTypes("Pesho", 22, true, ["cake", "banana", "fries"]);
//variableTypes("Gosho", 12, true, ["meat", "pineapple", "burger"]);
//variableTypes("Lili", 23, false, ["coca cola", "fries", "monster"]);
