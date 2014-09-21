using System;

namespace DistanceCalculator
{
    class DistanceCalculator
    {
        public static double CalculateDistance(Point3D a, Point3D b) 
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));
        }
    }
}
