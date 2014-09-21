using System;

namespace Point3D
{
    class PointMain
    {
        static void Main()
        {
            Point3D point = new Point3D(5, 2, 3);
            Console.WriteLine(point.ToString());

            Console.WriteLine(Point3D.StartingPoint); 
        }
    }
}
