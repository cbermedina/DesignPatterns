namespace DesignPatterns.Proxy.Service
{
    using DesignPatterns.Proxy.Classes;
    using DesignPatterns.Proxy.IService;
    using System;
    public class AccountBankBImplService : IAccountService
    {
        public Account withdrawals(Account account, double amount)
        {
            double currentBalance = account.getInitialBalance() - amount;
            account.setInitialBalance(currentBalance);
            Console.WriteLine($"Saldo actual: {account.getInitialBalance()}");
            return account;
        }


        public Account depositMoney(Account account, double amount)
        {
            double currentBalance = account.getInitialBalance() + amount + 0.20;
            account.setInitialBalance(currentBalance);
            Console.WriteLine($"Saldo actual: {account.getInitialBalance()}");
            return account;
        }

        public void showBalance(Account cuenta)
        {
            Console.WriteLine($"Saldo actual: {cuenta.getInitialBalance()}");
        }
    }
}
