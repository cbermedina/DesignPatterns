namespace DesignPatterns.Prototype
{
    using DesignPatterns.Prototype.Classes;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
			AccountAHImpl savingsAccount = new AccountAHImpl();
			savingsAccount.setAmount(200);

			AccountAHImpl savingsAccountTwo = new AccountAHImpl();

			AccountAHImpl clonedAccount = (AccountAHImpl)savingsAccount.clone();

			Console.WriteLine($"Initial account: {savingsAccount.toString()}");
			Console.WriteLine($"Second account: {savingsAccountTwo.toString()}");
			Console.WriteLine($"Cloned account: {clonedAccount.toString()}");
		}
	}
}
