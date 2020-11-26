
namespace DesignPatterns.Decorator.Clasess
{
	using System;

	public class Account
	{

		private int id;
		private String client;

		public Account()
		{

		}

		public Account(int id, String cliente)
		{
			this.id = id;
			this.client = cliente;
		}

		public int getId()
		{
			return id;
		}

		public void setId(int id)
		{
			this.id = id;
		}

		public String getClient()
		{
			return client;
		}

		public void setClient(String client)
		{
			this.client = client;
		}

	}
}
