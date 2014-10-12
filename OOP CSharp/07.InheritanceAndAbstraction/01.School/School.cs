namespace School
{
    using System;
    using System.Collections.Generic;
    
    class School
    {
        static void Main()
        {
            Teacher teacher = new Teacher("Veronica O'Donnle", new HashSet<Discipline>() 
            {
                new Discipline("Choreography", 5,
                    new List<Student>()
                    {
                        new Student("Pe6o", 1239567158),
                        new Student("Go6o", 1957584316),
                        new Student("Ivan4o", 196548036)
                    })            
            }, "Very gooood teacher.");

            Console.WriteLine(teacher);

            Console.WriteLine("\n-------------------------------------\n");


            Class someClass = new Class("Music", 
                new HashSet<Student>()
                { 
                    new Student("Gogo", 1685123547),
                    new Student("Petur", 9564875123)
                }, 
                new HashSet<Teacher>
                { 
                    new Teacher("Miss Lenovo", "Tech genious"),
                    new Teacher("Mr. John Cena", "He whoops ass...")
                });

            Console.WriteLine(someClass);
        }
    }
}
