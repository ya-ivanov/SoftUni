namespace Animals
{
    using System;

    class Tomcat : Cat
    {
        public new string Gender { get { return base.Gender; } }

        public Tomcat(string name, int age) : base (name, age, "Male")
        {}

        public new void ProduceSound()
        {
            Console.WriteLine("MYAAAL - I'm a Tomcat!!!");
        }
    }
}
