using DesignPatterns.Decorator.Clasess;
using DesignPatterns.Decorator.IService;
using System;

namespace DesignPatterns.Decorator.Decotator
{
    public class DecoratorShield : AccountDecorator
    {
        private IBankAccount _bankAccount;
        public DecoratorShield(IBankAccount bankAccount) : base(bankAccount)
        {
            _bankAccount = bankAccount;
        }

        public new void openAccount(Account account)
        {
            _bankAccount.openAccount(account);
            addShield(account);
        }

        public void addShield(Account c)
        {
            Console.WriteLine("Se agregó blindaje a la cuenta del cliente " + c.getClient());
        }
    }
}
