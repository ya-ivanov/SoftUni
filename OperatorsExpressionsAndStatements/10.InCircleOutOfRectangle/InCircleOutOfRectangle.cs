using System;

class InCircleOutOfRectangle
{
    static void Main()
    {
        double x, y;
        Console.WriteLine("Enter X:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y:");
        y = double.Parse(Console.ReadLine());

        if (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 2.25 && (x > 1 || x < 6 && y > -1 || y < 2))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}

