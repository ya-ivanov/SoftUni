using System;
using System.Numerics;
class TrailingZeroesInNFact
{
    static BigInteger findFactorial(BigInteger n)
    {
        BigInteger res = 1;
        for (int i = 1; i < n + 1; i++)
        {
            res *= i;
        }
        return res;
    }

    static int trailingZeroes(String num)
    {
        int zeros = 0;
        for (int i = num.Length - 1; i >= 0; i--)
        {
            if (num[i] == '0')
                zeros++;
            else
                break;
        }
        return zeros;
    }

    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\n\nTrailing zeroes is {0}: {1}\n", n, trailingZeroes(findFactorial(n).ToString()));
    }
}