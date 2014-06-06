using System;
using System.Globalization;
using System.Threading;
class DifferenceBetweenDates
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.WriteLine("Enter first date and second date [dd.MM.yyyy], each on a new line: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan difference = secondDate - firstDate;
        Console.WriteLine(difference.Days);
    }
}