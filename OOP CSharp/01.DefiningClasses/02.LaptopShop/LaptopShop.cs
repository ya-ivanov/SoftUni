using System;

namespace LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Laptop laptop = new Laptop("Acer 21", 1244.12, "asd", "asd");
            Console.WriteLine(laptop.ToString());
        }
    }
}
