using System;

class IsThirdDigit7
{
    static void Main()
    {
        int someNum = 0;
        Console.WriteLine("Enter number:");
        someNum = Int32.Parse(Console.ReadLine());

        if (someNum.ToString().Length < 3)
            Console.WriteLine("The number does not have a third digit.");
        else if (someNum.ToString()[someNum.ToString().Length - 3] == '7')
            Console.WriteLine("Thid digit from rigth to left IS 7.");
        else
            Console.WriteLine("Third digit from rigth to left is NOT 7.");
    }
}

