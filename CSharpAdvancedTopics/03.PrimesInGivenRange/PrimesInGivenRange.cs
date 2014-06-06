using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static bool isPrime(int num)
    {
        int res = 0;

        for (int i = 1; i < 100; i++)
        {
            if (num % i == 0)
                res++;
        }

        return res > 2 ? false : true;
    }

    static List<int> findPrimesInRange(int start, int end)
    {
        List<int> nums = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (isPrime(i))
                nums.Add(i);
        }

        return nums;
    }

    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine("Primes in the given range: {0}", String.Join(", ", findPrimesInRange(start, end)));
    }
}