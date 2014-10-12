namespace BankOfKurtovoKonare
{
    using System;

    class LoanAccount : Account
    {
        public LoanAccount(decimal balance, decimal interestPerMonth, Customer customer) : base(balance, interestPerMonth, customer) { }

        public override decimal Withdraw(decimal d)
        {
            Console.WriteLine("Your account type can't withdraw money!");
            return 0;
        }

        public override void Deposit(decimal deposit)
        {
            this.Balance += deposit;
        }

        public override decimal CalculateInterest(double months, decimal money)
        {
            if (this.Customer == Customer.Individual)
                if (months - 3 > 0)
                    return money * (1 + this.InterestRate * (decimal)(months - 3));
                else
                    return money * (1 + this.InterestRate);
            else if (this.Customer == Customer.Company)
            {
                if (months - 2 > 0)
                    return money * (1 + this.InterestRate * (decimal)(months - 2));
                else
                    return money * (1 + this.InterestRate);
            }
            else
                throw new TypeAccessException("Unknown account type.");
        }
    }
}
