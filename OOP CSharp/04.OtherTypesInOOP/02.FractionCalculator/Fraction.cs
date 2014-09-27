using System;

namespace FractionCalculator
{
    public class Fraction 
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            private set
            {
                this.numerator = value;
            }
        }
        
        public long Denominator
        {

            get { return this.denominator; }
            private set
            {
                if (value == 0)
                    throw new ArgumentException("The denominator's value can't be null.");
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2) 
        {
            long numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            long denomominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denomominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            long denomominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denomominator);
        }

        public override string ToString()
        {
            return ((decimal) this.numerator / this.denominator).ToString();
        }


    }
}
