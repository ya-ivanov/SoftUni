using System;
class RandomNumberInRange
{
    static void Main()
    {
        Console.WriteLine("Enter your numbers (n), (min), (max):");
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine("\nRandom numbers:\n");
        Random rnd = new Random();;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rnd.Next(min, max+1)); 
        }
    }
}