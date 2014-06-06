using System;
class NFactorialDividedByKFactorial
{
    static double findFactorialForTwoNumbersAndDivide(double n, double k) // Викам го само веднъж, следователно използвам само 1-ин цикъл
    {
        double res = 1, kFact = 0;
        for (int i = 1; i < n + 1; i++)
        {
            res *= i;
            if (i == k)
                kFact = res;
        }
        return res/kFact;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter N and K. [ 1 < k < n < 100 ]:");
        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());
        Console.WriteLine("\n{0}! / {1}! = {2}", n, k, findFactorialForTwoNumbersAndDivide(n, k));
    }
}