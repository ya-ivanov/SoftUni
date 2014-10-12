namespace StringBuilderExtentions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public static class Extentions
    {
        public static String Substring(this StringBuilder str, int start, int end) 
        {
            if (start < 0 || end >= str.Length)
                throw new ArgumentOutOfRangeException("The given arguments for 'start' and/or  'end' are invalid!");

            String res = "";

            for (int i = start; i <= end; i++)
                res += str.ToString()[i];

            return res;
        }

        public static StringBuilder RemoveText(this StringBuilder strBuilder, string text) 
        {
            string curText = strBuilder.ToString();

            while (curText.IndexOf(text, StringComparison.OrdinalIgnoreCase) != -1)
            {
                curText = curText.Replace(text, "");
            }

            return new StringBuilder(curText);
        }

        public static StringBuilder AppendAll<T>(this StringBuilder strBuilder, IEnumerable<T> items)
        {
            foreach (var item in items)
                strBuilder.Append(item.ToString());

            return strBuilder;
        }
    }
}
