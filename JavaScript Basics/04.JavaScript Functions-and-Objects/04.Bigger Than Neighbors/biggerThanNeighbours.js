function biggerThanNeighbours (index, arr) {
	if (index == 0 || index == arr.length-1){
		return "only one neighbour";
	} else if (index < 0 || index >= arr.length){
		return "invalid index";
	} else if (arr[index] > arr[index-1] && arr[index] > arr[index+1]) {
		return "bigger";
	} else {
		return "not bigger";
	}
}

console.log(biggerThanNeighbours(2, [1, 2, 3, 3, 5]));
//console.log(biggerThanNeighbours(2, [1, 2, 5, 3, 4]));
//console.log(biggerThanNeighbours(5, [1, 2, 5, 3, 4]));
//console.log(biggerThanNeighbours(0, [1, 2, 5, 3, 4]));