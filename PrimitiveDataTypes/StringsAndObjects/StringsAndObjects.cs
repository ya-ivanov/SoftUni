using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string str1 = "Hello", str2 = "World";
            Object myObj = str1 + " " + str2;
            string finishedStr = myObj.ToString();
            Console.WriteLine(finishedStr);
        }
    }
}
