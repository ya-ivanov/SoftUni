namespace InterestCalculator
{
    using System;

    public class InterestCalculator
    {
        private decimal paybackValue;

        public InterestCalculator(decimal money, double interest, int years, CalculateInterest del)
        {
            this.PaybackValue = del(money, interest, years);
        }

        public decimal PaybackValue
        {
            get { return this.paybackValue; }
            private set { this.paybackValue = value; }
        }

        public delegate decimal CalculateInterest(decimal sumOfMoney, double interest, int years);

    }
}
