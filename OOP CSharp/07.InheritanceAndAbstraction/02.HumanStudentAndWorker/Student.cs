namespace HumanStudentAndWorker
{
    using System;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstname, string lastname, string facNum) : base(firstname, lastname)
        {
            this.FacultyNumber = facNum;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("The Faculty Number shouldn't be null or empty.");
                if (value.Length < 5 || value.Length > 10)
                    throw new ArgumentOutOfRangeException("The faculty number should be 5..10 digits long.");
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Faculty Number: " + this.facultyNumber;
        }
    }
}
