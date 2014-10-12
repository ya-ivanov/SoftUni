namespace StudentsProblem
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public long GroupNumber { get; set; }
        public IList<int> Marks { get; set; }

        public Student(string firstName, string lastName, int age, long facultyNumber, string phone, string email, long groupNumber, IList<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }

        public override string ToString()
        {
            string toStr = String.Format(
                "Name: {0}\nFamily name: {1}\nAge: {2}\nFaculty number: {3}\nPhone number: {4}\nEmail: {5}\nGroup number: {6}\nMarks: ",
                this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email, this.GroupNumber);

            foreach (var mark in this.Marks)
                toStr += mark + " ";
            
            return toStr;
        }

    }
}
