using System;
class CheckForPlayCard
{
    static void Main()
    {
        string cards = " 2 3 4 5 6 7 8 9 10 J Q K ";
        Console.WriteLine("Enter score [0...9]:");
        string card = Console.ReadLine();
        if (cards.Contains(" " + card + " ") && card.Length < 3)
            Console.WriteLine("yes");
        else
            Console.WriteLine("no");
    }
}