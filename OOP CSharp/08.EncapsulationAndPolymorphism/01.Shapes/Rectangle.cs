namespace Shapes
{
    using System;

    class Rectangle : BasicShape
    {

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;    
        }

        public override double CalculatePerimether()
        {
            return 2 * (this.Width * this.Height);
        }
    }
}
