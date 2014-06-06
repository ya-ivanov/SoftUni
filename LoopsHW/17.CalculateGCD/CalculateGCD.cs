using System;

class CalculateGCD
{
    static int findGCD(int a, int b)
    {
        return b == 0 ? a : findGCD(b, a % b);//Рекурсия
    }

    static void Main()
    {
        Console.WriteLine("Enter a and b:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("The GCD of {0} and {1} is {2}", a, b, findGCD(a, b));
    }
}