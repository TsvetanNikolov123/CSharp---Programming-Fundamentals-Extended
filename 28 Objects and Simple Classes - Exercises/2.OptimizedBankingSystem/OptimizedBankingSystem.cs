namespace _2.OptimizedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }

    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            List<BankAccount> accounts = new List<BankAccount>(); 

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '|'}, StringSplitOptions.RemoveEmptyEntries);

                string bank = inputParams[0];
                string name = inputParams[1];
                decimal balance = decimal.Parse(inputParams[2]);

                BankAccount newBankAccount = new BankAccount();

                newBankAccount.Name = name;
                newBankAccount.Bank = bank;
                newBankAccount.Balance = balance;

                accounts.Add(newBankAccount);

                inputLine = Console.ReadLine();
            }

            var orderedAccounts = accounts
                .OrderByDescending(a => a.Balance)
                .ThenBy(a => a.Bank.Length);

            foreach (var account in orderedAccounts)
            {
                Console.WriteLine("{0} -> {1} ({2})",
                    account.Name, account.Balance, account.Bank);
            }
        }
    }
}
// Then you must print all Accounts, ordered by their balance, in descending order, 
// and then by length of the bank name, in ascending order.
// The accounts must be printed in the following way “{accountName} -> {balance} ({bank})”.
