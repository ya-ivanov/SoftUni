namespace HumanStudentAndWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HumanStudentAndWorker
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Bruce", "Wayne", "26AASD"),
                new Student("Tony", "Stark", "4R7D5"),
                new Student("Peter", "Parker", "1WAF7"),
                new Student("Black", "Widow", "AA639"),
                new Student("Loki", "Laufeyson", "DDDA25"),
                new Student("General", "Zod", "90A4D"),
                new Student("Reed", "Richards", "BBF2CF"),
                new Student("Charles", "Xavier", "1DD33"),
                new Student("Doctor", "Doom", "116X12"),
                new Student("Hal", "Jordan", "D1G10"),
                new Student("Green", "Arrow", "GR33N"),
                new Student("Nick", "Fury", "5625M7"),
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Chicken", "Little", 4869, 8),
                new Worker("Buggs", "Bunny", 600, 4),
                new Worker("Samurai", "Jack", 1253, 6),
                new Worker("Mojo", "Jojo", 1200, 10),
                new Worker("Iron", "Giant", 12399, 6),
                new Worker("Homer", "Simpson", 9600, 8),
                new Worker("Dr.", "Zoidberg", 4788, 12),
                new Worker("Kakashi", "Hatake", 3600, 7),
                new Worker("Johnny", "Bravo", 1236, 6),
                new Worker("Phineas", "Flynn", 4877, 5),
                new Worker("Balto", "The Dog", 45454, 12),
                new Worker("King", "Mufasa", 4599, 3),
            };


            var sortedStudents = students.OrderBy(student => student.FacultyNumber).ToList();  
            var sortedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            var mergedList = new List<Human>();
            mergedList.AddRange(sortedStudents);
            mergedList.AddRange(sortedWorkers);

            mergedList.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList().ForEach(human => 
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            });
        }
    }
}
