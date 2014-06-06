using System;
using System.Collections.Generic;

class ExtractURLsFromText
{
    static void Main()
    {
        List<string> text = new List<string>();
        text.AddRange(Console.ReadLine().Split(' '));
        Console.WriteLine();
        foreach (var word in text)
            if (word.StartsWith("http://") || word.StartsWith("https://") || word.StartsWith("www."))
                Console.WriteLine(word);
    }
}