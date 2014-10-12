namespace Animals
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public virtual string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public void ProduceSound() 
        {
            Console.WriteLine("Animaaaaaal!!!");
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}, Gender: {2}", this.Name, this.Age, this.Gender);
        }
    }
}
