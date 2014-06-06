using System;
class PlayWithVariables
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int \n2 --> double \n3 --> string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        { 
            case 1:
                Console.WriteLine("Please enter int: ");
                Console.WriteLine(int.Parse(Console.ReadLine())+1);
                break;
            case 2:
                Console.WriteLine("Please enter a double: ");
                Console.WriteLine(double.Parse(Console.ReadLine()) + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string: ");
                Console.WriteLine(Console.ReadLine() + "*");
                break;
            default:
                Console.WriteLine("Please choose from 1 to 3 next time.");
                break;
        }
    }
}