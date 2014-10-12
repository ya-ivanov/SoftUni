namespace Animals
{
    using System;

    class Kitten : Cat, ISound
    {
        public new string Gender { get { return base.Gender; } }

        public Kitten(string name, int age) : base (name, age, "Female")
        {}

        public new void ProduceSound()
        {
            Console.WriteLine("Miayu - I'm a kitten");
        }
    }
}
