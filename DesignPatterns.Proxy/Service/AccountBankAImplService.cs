namespace DesignPatterns.Proxy.Service
{
    using DesignPatterns.Proxy.Classes;
    using DesignPatterns.Proxy.IService;
    using System;
    public class AccountBankAImplService : IAccountService
    {
        public Account withdrawals(Account account, double amount)
        {
            double saldoActual = account.getInitialBalance() - amount;
            account.setInitialBalance(saldoActual);
            Console.WriteLine($"Saldo actual: {account.getInitialBalance()}");
            return account;
        }
        public Account depositMoney(Account account, double amount)
        {
            double saldoActual = account.getInitialBalance() + amount;
            account.setInitialBalance(saldoActual);
            Console.WriteLine($"Saldo actual: {account.getInitialBalance()}");
            return account;
        }
        public void showBalance(Account cuenta)
        {
            Console.WriteLine($"Saldo actual: {cuenta.getInitialBalance()}");
        }
    }
}