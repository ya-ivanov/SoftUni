namespace StudentsProblem
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StudentsProblem
    {
        static void Main() /// All student problems ...Where(problem => (problem.Title.IndexOf("*") == -1));
        {
            List<Student> students = new List<Student>()
            {
                new Student("Bruce", "Wayne", 47, 1593140174152, "0886932584", "batman@dc.com", 1, new List<int>() {6, 6, 5, 6}),// Enrolled in 2014
                new Student("Tony", "Stark", 45, 3625984236741, "0282365987", "iron_man@marvel.com", 1, new List<int>() {3, 5, 6, 4}),
                new Student("Doctor", "Who", 1127, 9761514009325, "0882147854", "dr_who@bbc.com", 2, new List<int>() {6, 4, 4, 4}),
                new Student("Peter", "Parker", 22, 8787953201477, "0882342342", "spidey@marvel.com", 1, new List<int>() {4, 2, 3, 2}),
                new Student("Jack", "O'Neall", 46, 0032321468452, "0882100365", "col_oneall@stargate.com", 2, new List<int>() {6, 6, 6, 6}), // Enrolled in 2014
                new Student("Samantha", "Carter", 39, 1022020547899, "+35928788991", "s_carter@sgc.com", 1, new List<int>() {6, 4, 5, 6}),
                new Student("John", "Sheppard", 34, 7436253234154, "0885330442", "sheppard@sg_atlantis.com", 2, new List<int>() {6, 6, 6, 5}),                
                new Student("Me", "McAnnonimus", 17, 1099140547899, "+359 288749991", "me_tseb@abv.bg", 1, new List<int>() {6, 6, 6, 6}), // Enrolled in 2014
                new Student("a", "b", 19, 1290253234154, "088128442", "someguy@home.com", 2, new List<int>() {2, 3, 6, 4}),
            };

            //Students By Group
            var studentsByGroup = students.OrderBy(student => student.GroupNumber);
            //foreach (var student in studentsByGroup) Console.WriteLine(student.FirstName);

            //Students By FirstName if Fistname > LastName alphabetically
            var studentsSortedByNames = students
                .OrderBy(student => student.FirstName)
                .Where(student => String.Compare(student.FirstName, student.LastName) < 0);
            //foreach (var student in studentsSortedByNames) Console.WriteLine(student.FirstName);

            var studentsByAge = students
                .Where(student => (student.Age > 18 && student.Age < 24))
                .Select(student => new List<string>() { student.FirstName, student.LastName, student.Age.ToString() });
            //foreach (var student in studentsByAge) Console.WriteLine("Name: {0} --- Last name: {1} --- Age: {2}", student[0], student[1], student[2]);

            //Students sorted By FirstName ThenBy LastName alphabetically
            var sortStudentsThenAgain = students
                .OrderBy(student => student.FirstName)
                .ThenBy(student => student.LastName);
            //foreach (var student in sortStudentsThenAgain) Console.WriteLine(student.FirstName +  " " + student.LastName);

            //Students filtered By Email domain
            var studentsEmailDomain = students
                .Where(student => student.Email.EndsWith("@abv.bg"));
            //foreach (var student in studentsEmailDomain) Console.WriteLine(student.FirstName + " - " + student.Email);

            //Students filtered By phone number
            var studentsFilterPhoneNumber = students
                .Where(student => student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2"));
            //foreach (var student in studentsFilterPhoneNumber) Console.WriteLine(student.FirstName + " - " + student.Phone);

            //Students filtered marks
            var excellentStudents = students
                .Where(student => student.Marks.Contains(6))
                .Select(student => new { FirstName = student.FirstName, Marks = student.Marks });
            //foreach (var student in excellentStudents) Console.WriteLine(student.FirstName);

            //Students who have exacly two '2's in the marks
            var weakStudents = students
                .Where(student => student.Marks.Count(x => x == 2) == 2)
                .Select(student => new { FirstName = student.FirstName, Marks = student.Marks });
            //foreach (var student in weakStudents) Console.WriteLine(student.FirstName);

            //Students which have enrolled in 2014 (5th and 6th digit in the faculty number must make 14)
            var latestStudents2014 = students
                .Where(student => student.FacultyNumber.ToString().IndexOf("14") == 4)
                .Select(student => new { FirstName = student.FirstName, Marks = student.Marks });
            //foreach (var student in latestStudents2014) Console.WriteLine(student.FirstName);
        }
    }
}
