using System;
class DigitAsWord
{
    static void Main()
    {
        char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        string[] digitsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        Console.WriteLine("Enter score [0...9]:");
        string dgt = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < 10; i++)
        {
            if (dgt == digits[i].ToString())
            {
                Console.WriteLine(digitsWord[i]);
                found = true;
            }
        }
        if (!found) Console.WriteLine("not a digit");
    }
}