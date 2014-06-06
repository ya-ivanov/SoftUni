using System;

class DivideBy5And7
{
    static void Main()
    {
        int integer = 0;
        Console.WriteLine("Enter integer:");
        integer = Int32.Parse(Console.ReadLine());
        if (integer % 5 == 0 && integer % 7 == 0)
            Console.WriteLine("{0} is dividable by 5 and 7  (without remainder) at the same time.", integer);
        else
            Console.WriteLine("{0} is NOT dividable by 5 and 7 (without remainder) at the same time.", integer);
    }
}
