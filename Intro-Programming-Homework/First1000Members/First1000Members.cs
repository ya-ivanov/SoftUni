﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First1000Members
{
    class First1000Members
    {
        static void Main()
        {
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i); }
                else { Console.WriteLine(i * (-1)); }
            }
        }
    }
}
