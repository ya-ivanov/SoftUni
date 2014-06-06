using System;

class ThirdBit
{
    static void Main()
    {
        int num = 0;
        Console.WriteLine("Enter number: ");
        num = Int32.Parse(Console.ReadLine());

        int bit = 1 << 3;
        int myBit = num & bit;

        if (myBit == 0)
            Console.WriteLine("Third bit is 0");
        else
            Console.WriteLine("Third bit is 1");
        
    }
}
