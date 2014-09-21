using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths
{
    public class Paths
    {
        static void Main()
        {
            Path3D path = new Path3D(new List<Point3D> { 
                new Point3D(45, 7, 3),
                new Point3D(-1, -3, 7),
                new Point3D(6, 1, 0),
                new Point3D(-5, -2, 6)
            });                                                                // Create a Path3D object

            //Console.WriteLine(path.ToString());                              // Print it to the console


            Storage.SavePath("myPath.txt", path);                              // Save it in a file
            Path3D newPath = Storage.ToPath3D(Storage.ReadPath("myPath.txt")); // Set newPath object with the Path3D objects created from the 
                                                                               // contents of the text file       
            Console.WriteLine(newPath.ToString());                             // Print the newPath to the console
        }
    }
}
