using System;

class PrimeChecker
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

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("isPrime? : {0}", isPrime(n));
    }
}