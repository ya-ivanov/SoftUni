using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName;
            string familyName;
            byte age;
            char genger;
            int IDNbr;
            int employeeNbr;
            Console.WriteLine("Enter employee's First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter employee's Family Name: ");
            familyName = Console.ReadLine();
            Console.WriteLine("Enter employee's Age: ");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee's genger(m/f): ");
            genger = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee's ID number: ");
            IDNbr = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee's unique number (27560000 to 27569999): ");
            employeeNbr = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Employee's unique number should be from 27560000 to 27569999. Enter new number bellow:");
                employeeNbr = int.Parse(Console.ReadLine());
            } while (employeeNbr > 27560000 && employeeNbr < 27569999);
            Console.Clear();
            Console.WriteLine("New employee signed successfully! Entered information: ");
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Family name: {0}", familyName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Genger: {0}", genger);
            Console.WriteLine("ID number: {0}", IDNbr);
            Console.WriteLine("Employee unique number: {0}", employeeNbr);
        }
    }
}
