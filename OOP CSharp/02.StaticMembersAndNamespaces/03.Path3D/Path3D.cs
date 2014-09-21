using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths
{
    public class Path3D
    {
        private List<Point3D> points = new List<Point3D>();

        public Path3D(){}

        public Path3D(List<Point3D> points)
        {
            this.Points = points;
        }

        public List<Point3D> Points
        {
            get { return this.points; }
            set
            {
                if (value == null || value.Count < 1)
                { 
                    throw new ArgumentException("Invalid points argument. Expected: List<Point3D>");
                }
                this.points = value;
            }
        }

        public void addPoint(Point3D point)
        {
            if (point == null)
                throw new ArgumentNullException("The point can't be null.");
            this.points.Add(point);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var point in this.points)
            {
                sb.AppendLine(String.Format("Point [X:{0}, Y:{1}, Z:{2}]", point.X, point.Y, point.Z));
            }
            return sb.ToString();
        }

    }
}
