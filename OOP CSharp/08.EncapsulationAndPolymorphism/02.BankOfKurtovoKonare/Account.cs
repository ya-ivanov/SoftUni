using System;

namespace BankOfKurtovoKonare
{
    abstract class Account
    {
        private Customer customer;

        private decimal interestRate; 

        private decimal balance;

        public Account(decimal balance, decimal interestPerMonth, Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interestPerMonth;
            this.Customer = customer;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("The customer can'this be null");
                this.customer = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The interest rate can't be negative.");
                this.interestRate = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                this.balance = value;
            }
        }

        public abstract void Deposit(decimal deposit);

        public abstract decimal Withdraw(decimal moneyToWithdraw);

        public abstract decimal CalculateInterest(double months, decimal money);

        public override string ToString()
        {
            return String.Format("Type: {0}, Balance: {1}, Interest: {2}%, Holder type: {3}",
                    this.GetType().Name, this.Balance, this.InterestRate, this.Customer);
        }
    }
}
