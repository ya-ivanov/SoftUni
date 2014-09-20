using System;

namespace Person
{
    class Persons
    {
        static void Main()
        {
            Person person = new Person("Superman", 17, "super@man.az");
            Console.WriteLine(person.ToString());
        }
    }
}