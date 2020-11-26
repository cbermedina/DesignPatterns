namespace DesignPatterns.Decorator.Decotator
{
    using DesignPatterns.Decorator.Clasess;
    using DesignPatterns.Decorator.IService;
    public abstract class AccountDecorator : IBankAccount
    {

        protected IBankAccount _accountDecorator;

        public AccountDecorator(IBankAccount bankAccount)
        {
            this._accountDecorator = bankAccount;
        }

        public void openAccount(Account account)
        {
            this._accountDecorator.openAccount(account);
        }
    }
}
