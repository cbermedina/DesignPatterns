namespace DesignPatterns.Proxy.Classes
{
	using System;
	public class Account
    {
		private int idAccount;
		private String user;
		private double initialBalance;

		public Account(int idAccount, String user, double initialBalance)
		{
			this.idAccount = idAccount;
			this.user = user;
			this.initialBalance = initialBalance;
		}

		public int getIdAccount()
		{
			return idAccount;
		}

		public void setIdAccount(int idCuenta)
		{
			this.idAccount = idCuenta;
		}

		public String getUser()
		{
			return user;
		}

		public void setUser(String usuario)
		{
			this.user = usuario;
		}

		public double getInitialBalance()
		{
			return initialBalance;
		}

		public void setInitialBalance(double saldoInicial)
		{
			this.initialBalance = saldoInicial;
		}
	}
}
