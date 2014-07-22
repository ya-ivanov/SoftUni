function cylinderVol (radius, height) {
	return (Math.PI*Math.pow(radius, 2)*height).toFixed(3);
}

console.log(cylinderVol(2, 4));
console.log(cylinderVol(5, 8));
console.log(cylinderVol(12, 3));