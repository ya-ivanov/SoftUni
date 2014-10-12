namespace BankOfKurtovoKonare
{
    using System;

    class DepositAccount : Account
    {
        public DepositAccount(decimal balance, decimal interestPerMonth, Customer customer) : base(balance, interestPerMonth, customer) { }

        public override decimal Withdraw(decimal moneyToWithdraw)
        {
            if (this.Balance - moneyToWithdraw < 0)
                throw new InvalidOperationException("There is not enough balance in your accout, to withdraw the given amount of money.");
            this.Balance -= moneyToWithdraw;
            return moneyToWithdraw;
        }

        public override void Deposit(decimal deposit)
        {
            this.Balance += deposit;
        }

        public override decimal CalculateInterest(double months, decimal money)
        {
            if (this.Balance > 0 && this.Balance < 1000)
                return money * (1 + 1 * (decimal)(months));
            return money * (1 + this.InterestRate * (decimal)(months));
        }
    }
}
