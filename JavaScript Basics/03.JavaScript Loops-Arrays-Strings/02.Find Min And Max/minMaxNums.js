function findMinAndMax (nums) {
	var max = nums[0], min = nums[0];

	for (var i = 0; i < nums.length; i++)
		if (nums[i] > max)
			max = nums[i];		
		else if (nums[i] < min)
			min = nums[i];	

	return "Min -> " + min + "\nMax -> " + max;
}

console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
//console.log(findMinAndMax([2, 2, 2, 2, 2]));
//console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));