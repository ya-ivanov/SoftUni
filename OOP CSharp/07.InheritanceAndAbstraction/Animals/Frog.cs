namespace Animals
{
    using System;

    class Frog : Animal, ISound
    {
        public Frog(string name, int age, string gender) : base (name, age, gender)
        {}

        public new void ProduceSound()
        {
            Console.WriteLine("Creckkk crackk - I'm a frog!!!");
        }
    }
}
