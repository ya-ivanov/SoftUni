namespace Animals
{
    using System;

    class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {}

        public new void ProduceSound()
        {
            Console.WriteLine("Miayy miauu - I'm a cat!!!");
        }

    }
}
