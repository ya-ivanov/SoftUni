using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class ExchangeValues
    {
        static void Main()
        {
            int a = 5, b = 10, temp = 0;
            Console.WriteLine("a = {0}; b = {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = {0}; b = {1}", a, b);
        }
    }
}
