namespace Shapes
{
    using System;

    class Circle : BasicShape
    {
        private double radius;

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The radius can't be a negative number.");
                this.radius = value;
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public override double CalculatePerimether()
        {
            return ((Math.PI * 2) * this.Radius);
        }
    }
}
