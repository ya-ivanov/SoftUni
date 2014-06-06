using System;
using System.Collections.Generic;

class LongestWordInAText
{
    static void Main()
    {
        List<string> text = new List<string>();
        text.AddRange(Console.ReadLine().Split(' '));
        string longest = text[0];

        for (int i = 0; i < text.Count; i++)
            if (text[i].Length > longest.Length)
                longest = text[i];
        
        Console.WriteLine(longest);
    }
}