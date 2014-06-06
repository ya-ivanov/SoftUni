using System;

class MoonGravity
{
    static void Main()
    {
        double weight = 0;
        Console.Write("Enter your weight: ");
        weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Is you were on the moon, you would be {0} KG's heavy.", weight * 0.17);
    }
}

