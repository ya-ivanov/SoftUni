using System;
class CalculateCombinations
{
    static double nFactorial = 0;
    static double kFactorial = 0;
    static double findFactorial(double n)
    {
        double res = 1;
        for (int i = 1; i < n + 1; i++)
        {
            res *= i;
        }
        return res;
    }
    
    static void findFactorialForTwoNumbers(double n, double k) // Намирам фактуриела на n и k с един цикъл.
    {
        double res = 1;
        for (int i = 1; i < n + 1; i++)
        {
            res *= i;
            if (i == k)
                kFactorial = res;
        }
        nFactorial = res;
    }

    static void Main()
    {
        Console.WriteLine("Enter N and K. [ 1 < k < n < 100 ]:");
        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());
        findFactorialForTwoNumbers(n, k);
        Console.WriteLine("Result: {0}", nFactorial / (kFactorial * findFactorial(n - k))); // Тук правя изчисленията и викам модул, в който е 2-рия цикъл.
    }
}