using System;
class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Biggest number: {0}", Math.Max(num1, Math.Max(num2, num3)));
    }
}