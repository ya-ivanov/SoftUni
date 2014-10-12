namespace School
{
    using System;

    public class Person
    {
        private string name;
        private string details;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, string details) : this(name)
        {
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("You passed invalid name paramether.");
                this.name = value;

            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("You passed invalid details paramether.");
                this.details = value;
            }
        }
    }
}
