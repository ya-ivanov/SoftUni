using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main() 
        {
            List<Computer> computers = new List<Computer>();

            Computer pc = new Computer("ABC", new List<Component> { 
                new Component("GPU NVIDIA GT-OVER-9000", 1005.00f),
                new Component("CPU INTEL", 2500.99f),
                new Component("Keyboard Apple 5", 469.69f, "Really overpriced duuuuude.")
            });

            Computer anotherPC = new Computer("ENIAC", new List<Component> { 
                new Component("HDD SEAGATE", 7305.00f, "Works faaaast maaannnn!!!!"),
                new Component("CPU INTEL", 2500.99f),
                new Component("Coca Cola Mouse", 69.69f)
            });

            computers.Add(pc);
            computers.Add(anotherPC);
            computers.OrderBy(Computer => Computer.Price).ToList().ForEach(x =>
            {
                Console.WriteLine(x.ToString());
            });
        }
    }
}
