using System;

class FourDigitNumber
{

    static String reverse(String str)
    {
        String temp = "";
        for (int i = 3; i >= 0; i--)
        {
            temp += str[i];
        }
        return temp;
    }

    static void Main()
    {
        int num = 0;
        Console.WriteLine("Enter your four digit number:");
        num = Int32.Parse(Console.ReadLine());

        Console.WriteLine("\n\nSum of the digits: {0}", Int32.Parse(num.ToString()[0].ToString()) + Int32.Parse(num.ToString()[1].ToString()) + Int32.Parse(num.ToString()[2].ToString()) + Int32.Parse(num.ToString()[3].ToString()));
        Console.WriteLine("Reverced number: {0}", reverse(num.ToString()));
        Console.WriteLine("Last digit in first position: {0}", num.ToString().Insert(0, num.ToString()[3].ToString()).Remove(4));
        Console.WriteLine("Second and Third Digits Replaced: {0}\n", num.ToString().Insert(1, num.ToString()[2].ToString()).Remove(3).Insert(3, num.ToString()[3].ToString()));
    }
}

