using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            int charCode = 0;
            for (charCode = 0; charCode < 32; charCode = charCode + 1)
            {
                char realChar = (char)charCode;
                Console.WriteLine("Char: {0} || Code: {1}", "This code represents control, not value.", charCode);
            }
            for (charCode = 32; charCode < 128; charCode = charCode + 1)
            {
                char realChar = (char)charCode;
                Console.WriteLine("Char: {0} || Code: {1}", realChar, charCode);
            }

            for (charCode = 128; charCode < 256; charCode = charCode + 1)
            {
                char realChar = (char)charCode;
                Console.WriteLine("Char: {0} || Code: {1}", realChar, charCode);
            }

            Console.WriteLine("\nAbove you see the ASCII table.");
           

        }
    }
}
