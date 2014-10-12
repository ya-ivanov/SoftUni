namespace Shapes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Shapes
    {
        static void Main()
        {
            List<IShape> shapes = new List<IShape>() 
            {
                new Circle(3),
                new Rectangle(2, 4),
                new Triangle(7, 12, 15),
                new Triangle(4, 4, 4),
                new Circle(15)
            };


            shapes.ForEach(shape => 
                Console.WriteLine(
                "Type: {0} --- Area: {1:0.00} --- Perimether: {2:0.00}",
                shape.GetType(), shape.CalculateArea(), shape.CalculatePerimether())
            );

        }
    }
}
