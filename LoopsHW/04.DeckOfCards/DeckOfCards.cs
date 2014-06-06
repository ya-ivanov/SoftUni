using System;
class DeckOfCards
{
    static void Main()
    {
        string[] colors = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        char[] notations = { '♣', '♦', '♥', '♦' };
        for (int i = 0; i < colors.Length; i++)
        {
            for (int n = 0; n < 4; n++)
            {
                Console.Write("{0}{1}  ", colors[i], notations[n]);
            }
            Console.WriteLine();
        }
    }
}