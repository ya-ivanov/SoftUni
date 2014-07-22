function lifetimeSupplyCalc (age, maxAge, amount) {
	var yearsToEat = maxAge - age;
	var daysToEat = yearsToEat * 365;
	return daysToEat * amount;
}

console.log(lifetimeSupplyCalc(17, 95, 2.5) + " liters of coca cola should be enough until I'm 95 years old");
console.log(lifetimeSupplyCalc(17, 69, 2) + " packs of semki should be enough until I'm 69 years old");
console.log(lifetimeSupplyCalc(17, 77, 0.5) + " KG's of french fries should be enough until I'm 77 years old");