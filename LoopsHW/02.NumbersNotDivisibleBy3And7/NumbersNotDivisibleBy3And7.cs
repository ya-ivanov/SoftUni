using System;
class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("From 1 to what number?");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i < max + 1; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
                Console.Write("{0} ", i);
        }
    }
}