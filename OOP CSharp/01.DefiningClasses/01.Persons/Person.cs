using System;

namespace Person
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == null || value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("The email must be null, or in valid email format!");
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The name must be valid.");
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The age must be between 0 and 100 [0...100]");
                }
            }
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;

        }

        public Person(string name, int age) : this(name, age, null) { }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}{2}", this.name, this.age, (this.email == null ? "" : "\nEmail: " + this.email));
        }
    }
}