using System;
class FromOneToN
{
    static void Main()
    {
        Console.WriteLine("From 1 to what number?");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i < max + 1; i++)
        {
            Console.WriteLine(i);
        }
    }
}

