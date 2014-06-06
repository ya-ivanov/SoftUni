using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterTenYears
{
    class AfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            int years = 0;
            years = Int32.Parse(Console.ReadLine());
            Console.WriteLine("After 10 years you will be {0} years old.", years+10);
        }
    }
}
