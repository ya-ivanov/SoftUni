using System;
using System.Collections.Generic;

class CountOfNames
{
    static List<string> removeOccur(List<string> finalList)
    {
        for (int i = 1; i < finalList.Count; i++)
            if (finalList[i - 1] == finalList[i])
            {
                finalList.RemoveAt(i - 1);
                i = 0;
            }
        return finalList;
    }

    static int countLetter(string letter, List<string> lst)
    {
        int times = 0;
        for (int i = 0; i < lst.Count; i++)
        {
            if (lst[i] == letter)
                times++;
        }
        return times;
    }

    static void Main()
    {
        List<string> letters = new List<string>();
        List<string> temp = new List<string>();

        letters.AddRange(Console.ReadLine().Split(' '));
        temp.AddRange(letters);
        letters.Sort();
        removeOccur(letters);

        foreach (var letter in letters)
            Console.WriteLine("{0} -> {1}", letter, countLetter(letter, temp));

    }
}