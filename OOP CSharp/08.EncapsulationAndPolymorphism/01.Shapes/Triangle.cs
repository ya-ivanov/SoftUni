namespace Shapes
{
    using System;

    class Triangle : BasicShape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.SideA = a;
            this.SideB = b;
            this.SideC = c;
        }

        public double SideA
        {
            get { return this.a; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The side must be a positive number!");
                this.a = value;
            }
        }

        public double SideB
        {
            get { return this.b; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The side must be a positive number!");
                this.b = value;
            }
        }

        public double SideC
        {
            get { return this.c; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The side must be a positive number!");
                this.c = value;
            }
        }


        public override double CalculateArea()
        {
            double halfP = CalculatePerimether()/2;
            return Math.Sqrt(halfP *(halfP-this.a) * (halfP - this.b) * (halfP - this.c));
        }

        public override double CalculatePerimether()
        {
            return (this.a + this.b + this.c);
        }
    }
}
