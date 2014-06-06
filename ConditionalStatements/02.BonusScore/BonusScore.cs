using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enter score [0...9]:");
        int score = int.Parse(Console.ReadLine());
        int bonus = score;
        if (score >= 1 && score <= 3)
            Console.WriteLine(bonus *= 10);
        else if (score >= 4 && score <= 6)
            Console.WriteLine(bonus *= 100);
        else if (score >= 7 && score <= 9)
            Console.WriteLine(bonus *= 1000);
        else if (score < 1 || score > 9)
            Console.WriteLine("invalid score");
    }
}