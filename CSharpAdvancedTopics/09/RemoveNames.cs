using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        List<string> listOne = new List<string>();
        List<string> listTwo = new List<string>();

        listOne.AddRange(Console.ReadLine().Split(' '));
        listTwo.AddRange(Console.ReadLine().Split(' '));

        foreach (var item in listTwo)
        {
            while (listOne.IndexOf(item) != -1)
                listOne.RemoveAt(listOne.IndexOf(item));
        }

        Console.WriteLine(String.Join(" ", listOne));
    }
}