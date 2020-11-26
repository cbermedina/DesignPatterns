namespace DesignPatterns.Memento.Classes
{
    public class Memento
	{
		private Game _state;
		public Memento(Game state)
		{
			this._state = state;
		}

		public Game getState()
		{
			return _state;
		}
	}
}
