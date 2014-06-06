using System;
class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter two integer variables:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine()), temp = 0;
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}