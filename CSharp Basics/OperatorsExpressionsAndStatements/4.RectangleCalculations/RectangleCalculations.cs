using System;

class RectangleCalculations
{
    static void Main()
    {
        double width, height;

        Console.WriteLine("Enter the rectangle's width:");
        width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the rectangle's height:");
        height = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimether: {0}", 2*width + 2*height);
        Console.WriteLine("Area: {0}", width*height);

    }
}

