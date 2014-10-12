namespace BankOfKurtovoKonare
{
    using System;

    class MortgageAccount : Account
    {
        public MortgageAccount(decimal balance, decimal interestPerMonth, Customer customer) : base(balance, interestPerMonth, customer) {}

        public override decimal Withdraw(decimal moneyToWithdraw)
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
                 if (months - 6 > 0)
                     return money * (1 + this.InterestRate * (decimal)(months - 6));
                else
                     return money * (1 + this.InterestRate);
            else if (this.Customer == Customer.Company)
            {
                decimal interest = 0;
                for (int i = 0; i < months; i++)
                {
                    if (i <= 12)
                        interest += this.InterestRate / 2;
                    else
                        interest += this.InterestRate;
                }
                return money * (1 + interest * (decimal)(months));
            }
            else
                throw new TypeAccessException("Unknown account type.");
        }

    }
}
