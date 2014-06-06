using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareFloats
{
    class CompareFloats
    {
        static void Main()
        {
            double a = 0, b = 0;
            Console.WriteLine("Enter numbers for 'a' and for 'b' on separate lines:");
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Is A equal to B: {0}", Math.Max(a, b) - Math.Min(a, b) < 0.000001);
        }
    }
}
