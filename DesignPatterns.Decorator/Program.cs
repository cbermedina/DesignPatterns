using DesignPatterns.Decorator.Clasess;
using DesignPatterns.Decorator.Decotator;
using DesignPatterns.Decorator.IService;
using DesignPatterns.Decorator.Service;
using System;

namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Account accountOne = new Account(70, "Savings Accountt");
            savingsAccount(accountOne);
            Account accountTwo = new Account(500, "Current Account");
            currentAccount(accountTwo);
        }

        private static void currentAccount(Account account)
        {
            IBankAccount currentAccount = new CurrentAccount();
            IBankAccount shieldAccount = new DecoratorShield(currentAccount);
            //currentAccount.openAccount(account);
            shieldAccount.openAccount(account);
        }

        private static void savingsAccount(Account account)
        {
            IBankAccount bankAccount = new SavingsAccount();
            IBankAccount shieldBankAccount = new DecoratorShield(bankAccount);
            //bankAccount.openAccount(c);
            shieldBankAccount.openAccount(account);
        }
    }
}
