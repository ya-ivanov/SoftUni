using System;
class BeerTime
{
    static int Main()
    {
        Console.WriteLine("Enter time: [01...12]:[00...59] [AM/PM] (Mind the '0' before the hour!)");
        string time = Console.ReadLine();

        if (time.Length < 7)
        { 
            Console.WriteLine("Please enter correct data. Example: 04:33 PM");
            return 0;
        }

        int hours = int.Parse(time[0].ToString() + time[1]);
        string am_pm = time[6].ToString() + time[7];

        if (hours > 1 && hours < 3)
            Console.WriteLine("beer time");
        else if (hours > 0 && am_pm == "PM" && hours < 13)
            Console.WriteLine("beer time");
        else if (hours < 3 && am_pm == "AM")
            Console.WriteLine("beer time");
        else
            Console.WriteLine("non-beer time");
        return 0;
    }
}