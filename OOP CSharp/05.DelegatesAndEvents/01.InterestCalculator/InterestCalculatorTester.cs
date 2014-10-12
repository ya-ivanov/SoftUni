namespace InterestCalculator
{
    using System;

    class InterestCalculatorTester
    {
        static void Main()
        {
            InterestCalculator compoundCalculator = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine("{0:0.0000}", compoundCalculator.PaybackValue);

            InterestCalculator simpleCalculator = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine("{0:0.0000}", simpleCalculator.PaybackValue);
        }

        public static decimal GetSimpleInterest(decimal money, double interest, int years) 
        {
            return money * (decimal)(1 + (interest * years / 100));
        }

        public static decimal GetCompoundInterest(decimal money, double interest, int years)
        {
            return money * (decimal)Math.Pow(1 + (interest / 12 / 100), years * 12);
        }
    }
} 
