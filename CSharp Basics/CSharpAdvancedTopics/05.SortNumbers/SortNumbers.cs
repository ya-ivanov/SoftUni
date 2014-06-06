using System;

class SortNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numsSorted = new int[n];

        for (int i = 0; i < n; i++)
            numsSorted[i] = int.Parse(Console.ReadLine());
        
        Array.Sort(numsSorted);
        Console.WriteLine("\nSorted numbers: \n{0}", String.Join("\n", numsSorted));
    }
}