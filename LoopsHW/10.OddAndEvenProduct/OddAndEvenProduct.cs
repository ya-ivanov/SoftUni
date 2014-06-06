using System;
class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter your numbers:");
        string nums = Console.ReadLine();
        String[] numbers = nums.Split(' ');
        double oddProduct = 1, evenProduct = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if ((i + 1) % 2 == 0)
                evenProduct *= double.Parse(numbers[i]);
            else
                oddProduct *= double.Parse(numbers[i]);
        }
        Console.WriteLine(oddProduct==evenProduct?"\nyes\nproduct = {0}" : "\nno\nodd_product = {1}\neven_product = {0}", evenProduct, oddProduct);
    }
}