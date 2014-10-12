namespace CustomLINQExtentions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class CustomLINQExtentions
    {
        static void Main()
        {
            List<String> list = new List<string>() { "1", "2", "magare", "3", "a", "c++"};

            /// WhereNot Extention demonstration
            IEnumerable<string> result = list.WhereNot(item => item.ToString().Length > 1);
            foreach (var item in result)
                Console.WriteLine(item);

            // Repeat extention demonstration
            result = list.Repeat(2);
            foreach (var item in result)
                Console.WriteLine(item);

            // WhereEndsWith extention demonstration
            result = list.WhereEndsWith(new List<String> { "e", "+" });
            foreach (var item in result)
                Console.WriteLine(item);

        }
    }
}
