namespace DesignPatterns.Proxy
{
    using DesignPatterns.Proxy.Classes;
    using DesignPatterns.Proxy.IService;
    using DesignPatterns.Proxy.Proxy;
    using DesignPatterns.Proxy.Service;
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(30, "My Account", 300);
            
            IAccountService accountProxy = new AccountProxy(new AccountBankBImplService());
            accountProxy.showBalance(account);
            account = accountProxy.depositMoney(account, 50);
            account = accountProxy.withdrawals(account, 20);
            accountProxy.showBalance(account);
        }
    }
}
