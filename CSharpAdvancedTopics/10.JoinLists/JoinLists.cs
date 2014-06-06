using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        List<string> listOne = new List<string>();
        List<string> listTwo = new List<string>();
        List<int> finalList = new List<int>();

        listOne.AddRange(Console.ReadLine().Split(' '));
        listTwo.AddRange(Console.ReadLine().Split(' '));

        foreach (var item in listOne)
            finalList.Add(int.Parse(item));
        
        foreach (var item in listTwo)
            finalList.Add(int.Parse(item));
        
        finalList.Sort();

        for (int i = 1; i < finalList.Count; i++)
            if (finalList[i - 1] == finalList[i])
            {
                finalList.RemoveAt(i-1);
                i = 0;
            }
        
        Console.WriteLine(string.Join(" ", finalList));
    }
}