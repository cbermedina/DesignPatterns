namespace DesignPatterns.Decorator.Service
{
    using DesignPatterns.Decorator.Clasess;
    using DesignPatterns.Decorator.IService;
    using System;
    public class SavingsAccount : IBankAccount
    {
        public void openAccount(Account account)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Se abrió una cuenta de Ahorros");
            Console.WriteLine("Cliente: " + account.getClient());
        }
    }
}
