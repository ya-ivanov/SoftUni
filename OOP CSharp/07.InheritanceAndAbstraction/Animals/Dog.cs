namespace Animals
{
    using System;

    class Dog : Animal, ISound
    {
        public Dog(string name, int age, string gender) : base (name, age, gender)
        {}

        public new void ProduceSound()
        {
            Console.WriteLine("Woff woff - I'm a dog!!!");
        }
    }
}
