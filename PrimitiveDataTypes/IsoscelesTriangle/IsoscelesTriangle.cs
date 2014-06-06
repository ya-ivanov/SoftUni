using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char img = '\u00a9';
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int start = 3, change = 0;

            Console.WriteLine("    \u00a9   ");
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 7; k++)
                {
                    if (i == 2)
                    {
                        Console.WriteLine(" \u00a9 \u00a9 \u00a9 \u00a9");
                        break;
                    }
                    else if (k == start)
                    {
                        Console.Write(img);
                        start--;
                        change += 2;
                        Console.Write(new String(' ', change - 1));
                        Console.Write(img);
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
