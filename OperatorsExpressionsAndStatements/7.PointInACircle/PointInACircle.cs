using System;

class PointInACircle
{
    static void Main()
    {
        double x, y;
        Console.WriteLine("Enter X:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y:");
        y = double.Parse(Console.ReadLine());

        if (x*x + y*y <= 4)
            Console.WriteLine("The point is inside the circle.");
        else
            Console.WriteLine("The Point is outside the circle.");
    }
}
