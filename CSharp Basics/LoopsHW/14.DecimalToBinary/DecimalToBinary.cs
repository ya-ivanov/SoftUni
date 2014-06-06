using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        long decimalNum = long.Parse(Console.ReadLine());
        string binary = "";

        while (decimalNum > 0)
        {
            binary = binary.Insert(0, (decimalNum % 2).ToString());
            decimalNum /= 2;
        }
        Console.WriteLine("\nYour number in binary: {0}\n\n", binary);
    }
}