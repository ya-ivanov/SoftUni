using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            double[] doubles = { 34.567839023, 3456.091, 8923.1234857};
            float floats = 12.345f ;

            Console.WriteLine("Doubles: ");
            for (int i = 0; i < doubles.Length; i++)
            {
                Console.WriteLine(doubles[i]);
            }

            Console.WriteLine("\n\nFloats:\n{0}", floats);
        }
    }
}