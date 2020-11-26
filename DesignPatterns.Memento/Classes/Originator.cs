namespace DesignPatterns.Memento.Classes
{
    public class Originator
	{
		private Game _state;

		public void setState(Game estado)
		{
			this._state = estado;
		}
		public Game getState()
		{
			return _state;
		}
		public Memento save()
		{
			return new Memento(_state);
		}
		public void restore(Memento memento)
		{
			this._state = memento.getState();
		}
	}
}
