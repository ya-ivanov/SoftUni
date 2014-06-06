using System;
class CalculateAFormula
{
    static double findFactorial(double n)
    {
        double res = 1;
        for (int i = 1; i < n+1; i++)
        {
            res *= i;
        }
        return res;
    }

    static void Main()
    {
        Console.WriteLine("From two numbers:");
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double s = 1;

        for (int i = 1; i < n+1; i++)
        {
            s += (findFactorial(i)/Math.Pow(x, i));
        }

        Console.WriteLine(Math.Round(s, 5));
    }
}