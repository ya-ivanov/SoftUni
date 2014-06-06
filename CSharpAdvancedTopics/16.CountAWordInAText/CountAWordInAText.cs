using System;

class CountAWordInAText
{
    static int countWord(string word, string text)
    {
        string[] allWords = text.Split(new char[] { '.', ' ', ',', '"', '\'', '@', '!', '?', '/', '\\', ';', ':', '(', ')' });
        int times = 0;

        for (int i = 0; i < allWords.Length; i++)
            if (allWords[i].ToLower() == word.ToLower())
                times++;

        return times;
    }

    static void Main()
    {
        string word = Console.ReadLine(), text = Console.ReadLine();
        Console.WriteLine(countWord(word, text));
    }
}