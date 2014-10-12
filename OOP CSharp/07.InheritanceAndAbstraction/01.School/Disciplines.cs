namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Discipline
    {
        private string name;
        private int numberOfLectures;
        private List<Student> students;

        public Discipline(string name, int lectures, List<Student> students)
        {
            this.Name = name;
            this.numberOfLectures = lectures;
            this.Students = students;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("The name of the discipline can't be null or empty.");
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The number of lectures can't be negative.");
                this.numberOfLectures = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set
            {
                if (value == null || value.Count <= 0)
                    throw new ArgumentException("The discipline should contain students.");
                this.students = value;
            }
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(String.Format("Name: {0}, Number of Lectures: {1}\nStudents:\n", this.name, this.numberOfLectures));

            foreach (var student in this.students) 
                strBuilder.AppendLine(student.ToString());
            

            return strBuilder.ToString();
        }

    }
}
