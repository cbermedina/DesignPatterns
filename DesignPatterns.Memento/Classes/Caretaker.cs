namespace DesignPatterns.Memento.Classes
{
	using System.Collections.Generic;
	public class Caretaker
	{
		private List<Memento> _mementos = new List<Memento>();

		public void addMemento(Memento memento)
		{
			_mementos.Add(memento);
		}
		public Memento getMemento(int index)
		{
			return _mementos[index];
		}
	}
}
