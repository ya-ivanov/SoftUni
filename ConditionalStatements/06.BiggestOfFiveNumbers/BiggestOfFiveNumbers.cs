using System;
class BiggestOfFiveNumbers
{
    static void Main()
    {
        double[] numbers = new double[5];
        Console.WriteLine("Enter 5 numbers (each on a new line):");
        
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = int.Parse(Console.ReadLine());

        double biggestNum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
            if (biggestNum < numbers[i])
                biggestNum = numbers[i];

        Console.WriteLine("The biggest number is: {0}", biggestNum);
    }
}