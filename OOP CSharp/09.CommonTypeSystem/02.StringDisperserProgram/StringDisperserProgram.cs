namespace StringDisperserProgram
{
    using System;
    using System.Collections;

    public class StringDisperserProgram
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("a", "b", "c", "d", "e", "building");

            foreach (var chr in stringDisperser)
            {
                Console.Write(chr + " ");
            }
        }
    }
}
