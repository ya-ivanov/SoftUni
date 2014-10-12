namespace StringBuilderExtentions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    class StringBuilderExtentions
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder();

            str.Append("1234");
            Console.WriteLine(str.Substring(1, 2));

            str = str.RemoveText("2");
            Console.WriteLine(str);

            str.Clear();

            str.AppendAll(new List<String>() { "a", "b" })
               .AppendAll(new List<int>() { 11, 4, 6, 6 })
               .AppendAll(new List<double>() { 1.1, 7.96, 6.23, 0.5 });

            Console.WriteLine(str);



        }

    }
}
