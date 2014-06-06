using System;
class LongestAreaInArray
{

    static void Main(string[] args)
    {
        
        int n = int.Parse(Console.ReadLine());
        string[] strs = new string[n];

        for (int i = 0; i < n; i++)
            strs[i] = Console.ReadLine();

        string str = strs[0];
        int longest = 1, curLongest = 0;
        for (int i = 1; i < n; i++)
        {
            if (strs[i - 1] == strs[i])
            {
                curLongest++;
            }
            else
                curLongest = 0;

            if (curLongest >= longest)
            {
                longest = curLongest;
                str = strs[i];
            }

        }

        Console.WriteLine(longest+1);
        for (int i = 0; i <= longest; i++)
        {
            Console.WriteLine(str);
        }        
    }
}