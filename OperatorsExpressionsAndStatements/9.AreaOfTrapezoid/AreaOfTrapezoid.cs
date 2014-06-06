using System;

class AreaOfTrapezoid
{
    static void Main()
    {
        double a, b, h;
        Console.WriteLine("Enter a, b and h (each on a new line):");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());
        Console.WriteLine("Area of trapezoid: {0}", ((a+b)/2)*h);
    }
}

