namespace Animals
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Animals
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Cat("Silvester", 12, "Male"),
                new Tomcat("Tom", 10),
                new Dog("Rex", 10, "Male"),
                new Kitten("Lesly", 2),
                new Frog("Price", 17, "Male"),
                new Tomcat("Somecat", 23),
                new Dog("Balto", 17, "Male")
            };

            var averageAge =
                
                from an in animals
                group an by new { GroupName = an.GetType().Name } into gr
                select new
                {
                    GroupName = gr.Key.GroupName,
                    AvarageAge = gr.Average(an => an.Age)
                };


            foreach (var animal in averageAge)
            {
                Console.WriteLine(String.Format("Group: {0}, Avarage Age: {1:0.00}.", animal.GroupName, animal.AvarageAge));
            }   
        }
    }
}
