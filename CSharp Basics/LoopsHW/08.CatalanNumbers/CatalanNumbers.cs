using System;
class CatalanNumbers
{
    static double findFactorial(double n)
    {
        double res = 1;
        for (int i = 1; i < n + 1; i++)
        {
            res *= i;
        }
        return res;
    }

    static void Main()
    {
        Console.WriteLine("Enter N  [ 1 < n < 100 ]:");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine(findFactorial(2*n) / (findFactorial(n+1)*findFactorial(n)));
    }
}