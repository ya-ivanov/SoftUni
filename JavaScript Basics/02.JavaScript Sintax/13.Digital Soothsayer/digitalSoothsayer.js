function soothsayer (years, langs, cities, cars) {
	function newRandom () {
		return Math.floor(Math.random()*5);
	}
	return [years[newRandom()], langs[newRandom()], cities[newRandom()], cars[newRandom()]];
}

var myFuture = soothsayer([4, 5, 6, 1, 9],
				   			["C#", "JS", "Java", "Python", "Ruby"], 
				   			["London", "California", "Berlin", "New York", "LA"], 
				   			["Lexus", "Mercedes", "BMW", "Audi", "Ferrari"]);

console.log("You will work " + myFuture[0] + " years on " + myFuture[1]);
console.log("You will live in " + myFuture[2] + " and drive " + myFuture[3]);
