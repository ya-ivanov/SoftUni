using System;
class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N  [ 1 < n < 20 ]:"); // Ще се наложи да максимизирате конзолата.
        int n = int.Parse(Console.ReadLine());
        int numToStart = 0;
        for (int i = 0; i < n; i++)
        {
            numToStart = i + 1;
            for (int m = 0; m < n; m++)
            {
                Console.Write("{0} ", String.Format("{0,-3}", String.Format("{0," + ((3 + numToStart.ToString().Length) / 2).ToString() + "}", numToStart.ToString())));
                numToStart++;
            }
            
            Console.WriteLine("\n");
        }
    }
}