using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number:");
        string biraryNum = Console.ReadLine() ;
        long decimalNum = 0;

        for (int i = 0, mmm = biraryNum.Length - 1; i <= biraryNum.Length - 1; i++, mmm--)
            decimalNum += long.Parse((int.Parse(biraryNum[i].ToString()) * Math.Pow(2, mmm)).ToString());
        Console.WriteLine("\n\n{0} is {1}\n\n", biraryNum, decimalNum);
    }
}