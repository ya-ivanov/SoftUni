namespace BankOfKurtovoKonare
{
    using System;
    using System.Collections.Generic;

    class BankOfKurtovoKonare
    {
        static void Main()
        {
            List<Account> accounts = new List<Account>()
            {
                new DepositAccount(15000m, 1.2m, Customer.Company),
                new LoanAccount(200m, 0.6m, Customer.Individual),
                new MortgageAccount(5966m, 2.2m, Customer.Company),
                new DepositAccount(969633m, 0.3m, Customer.Individual),
                new LoanAccount(690m, 0.6m, Customer.Individual),
                new MortgageAccount(56m, 2.2m, Customer.Company),
                new DepositAccount(6433m, 6.3m, Customer.Individual),
                new LoanAccount(630m, 0.69m, Customer.Individual),
                new MortgageAccount(7200m, 0.20m, Customer.Company),
                new DepositAccount(33m, 0.36m, Customer.Individual)
            };

            accounts.ForEach(account =>
            {
                Console.WriteLine(account.ToString());
            });


            Console.WriteLine("\n\nAfter changes:\n");
            accounts[0].Deposit(500m);
            accounts[3].Deposit(500m);
            accounts[2].Deposit(500m);
            accounts[7].Withdraw(500m); // This guy can't withdraw money


            accounts.ForEach(account =>
            {
                Console.WriteLine(account.ToString());
            });


        }
    }
}
