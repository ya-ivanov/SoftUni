using System;
using System.Collections.Generic;
class RandomizeNumbers
{
    static void randomize(List<int> list)
    {
        int n = list.Count;
        Random rnd = new Random();
        while (n > 1)
        {
            int k = (rnd.Next(0, n) % n);
            n--;
            int value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for (int i = 1; i < n+1; i++)
            numbers.Add(i);
        
        randomize(numbers);

        Console.WriteLine("\nNumbers from 1 to {0} randomized:", n);

        for (int i = 0; i < n; i++)
            Console.WriteLine(numbers[i]);

    }
}