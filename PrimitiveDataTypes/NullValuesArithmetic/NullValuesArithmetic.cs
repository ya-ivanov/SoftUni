using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? intNum = null;
            double? doubleNum = null;
            Console.WriteLine(intNum);
            Console.WriteLine(doubleNum);
            Console.WriteLine(50 + intNum);

            intNum = 10;
            doubleNum = 5.80;
            Console.WriteLine(intNum);
            Console.WriteLine(doubleNum);
            Console.WriteLine(50 + intNum);
        }
    }
}
