using System;

class BitAtPosition
{
    static void Main()
    {
        int pos = 0, num = 0;
        Console.Write("Enter number, and then position: ");
        num = Int32.Parse(Console.ReadLine());
        pos = Int32.Parse(Console.ReadLine());

        int bit = num >> pos;
        int myBit = bit & 1;

        if (myBit == 1)
            Console.WriteLine("TRUE");
        else
            Console.WriteLine("FALSE");
    }
}

