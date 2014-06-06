using System;
class IsItPrime
{


    static int isPrime(int n)
    {
        int dividers = 0;
        for (int i = 1; i < 101; i++)
        {
            if (n == 1 || n < 2)
                return 100;
            else if (n % i == 0) dividers++;
        }
        return dividers;
    }

    static void Main()
    {
        int num = 0;
        Console.WriteLine("Enter number:");
        num = Int32.Parse(Console.ReadLine());

        if (isPrime(num) < 3)
            Console.WriteLine("The number {0} is prime.", num);
        else
            Console.WriteLine("The number {0} is NOT prime.", num);

    }
}

