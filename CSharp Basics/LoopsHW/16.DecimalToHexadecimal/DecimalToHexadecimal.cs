using System;
using System.Text;

class DecimalToHexadecimal
{
    static string decToHex(long dec)
    {
        var sb = new StringBuilder();
        while (dec > 1)
        {
            var r = dec % 16;
            dec /= 16;
            sb.Insert(0, ((int)r).ToString("X"));
        }
        return sb.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter decimal value");
        long dec = long.Parse(Console.ReadLine());
        Console.WriteLine("Hex {0} is dec {1}", dec, decToHex(dec));
    }
}