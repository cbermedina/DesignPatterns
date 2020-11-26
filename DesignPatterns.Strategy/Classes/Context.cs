namespace DesignPatterns.Strategy.Classes
{
    using DesignPatterns.Strategy.IService;
    public class Context
    {
		private IStrategy _strategy;

		public Context(IStrategy strategy)
		{
			this._strategy = strategy;
		}

		public void execute()
		{
			this._strategy.analyze();
		}
	}
}
