using System;

class FobonacciNumbers
{

    static int Fib(int num)
    {
        int firstNum = 0, secondNum = 1, next;

        if (num == 0)
            return 1;
        else if (num == 1)
            return 1;
        else
            for (int i = 1; i < num + 1; i++)
            {
                next = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = next;
                
                if (i == num)
                    return next;
            }
        return 0;
    }


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int res= Fib(n);
        Console.WriteLine("{0} fibonacci number: {1}", n, res);
    }
}