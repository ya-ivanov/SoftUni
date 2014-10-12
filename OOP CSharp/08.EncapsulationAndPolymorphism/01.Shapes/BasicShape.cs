using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The width must be a positive number!");
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The height must be a positive number!");
                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimether();
    }
}
