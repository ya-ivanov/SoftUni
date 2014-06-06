using System;

class MultiplicationSign
{

    static double getSign(double a, double b, double c)
    {
        double plus = 0;
        if (a == 0 || b == 0 || c == 0) return 404;
        if (a > 0) plus++;
        if (b > 0) plus++;
        if (c > 0) plus++;
        return plus;
    }

    static void Main()
    {
        Console.WriteLine("Enter 3 numbers:");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        if (getSign(num1, num2, num3) == 3)
            Console.WriteLine("+");
        else if (getSign(num1, num2, num3) == 2)
            Console.WriteLine("-");
        else if (getSign(num1, num2, num3) == 1)
            Console.WriteLine("+");
        else if (getSign(num1, num2, num3) == 404)
            Console.WriteLine("0");
        else if (getSign(num1, num2, num3) == 0)
            Console.WriteLine("-");
    }
}