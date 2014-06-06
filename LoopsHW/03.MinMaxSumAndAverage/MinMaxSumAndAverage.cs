using System;
using System.Collections.Generic;
class MinMaxSumAndAverage //Не знам дали е само при мен или нещо се бъркам, но в примерните резултати на задачата има грешки.
{                         //Може да е само при мен. Ако е така се извинявам.

    static int findMin(List<int> nums)
    {
        int minNum = nums[0];
        for (int i = 1; i < nums.Count; i++)
        {
            if (minNum > nums[i])
                minNum = nums[i];
        }
        return minNum;
    }

    static int findMax(List<int> nums)
    {
        int maxNum = nums[0];
        for (int i = 1; i < nums.Count; i++)
        {
            if (maxNum < nums[i])
                maxNum = nums[i];
        }
        return maxNum;
    }

    static int calcSum(List<int> nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    static double calcAvg(List<int> nums)
    {
        double sum = calcSum(nums);
        return Math.Round(sum / nums.Count, 2);
    }


    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter your numbers. When you want to end, enter anything thats not a number.");
        while (true)
        {
            try
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            catch (Exception) { break; }
        }

        Console.WriteLine("min = {0}", findMin(numbers));
        Console.WriteLine("max = {0}", findMax(numbers));
        Console.WriteLine("sum = {0}", calcSum(numbers));
        Console.WriteLine("avg = {0}", calcAvg(numbers));
    }
}