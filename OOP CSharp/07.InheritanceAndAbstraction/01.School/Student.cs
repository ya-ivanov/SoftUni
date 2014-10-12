namespace School
{
    using System;

    class Student : Person
    {
        private long classNumber;

        public Student(string name, long classNum) : base(name)
        {
            this.Name = name;
            this.ClassNumber = classNum;
        }

        public long ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value;}
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Class Number: {1}", this.Name, this.ClassNumber);
        }
    }
}
