namespace DesignPatterns.Memento
{
	using DesignPatterns.Memento.Classes;
	using System;
	class Program
    {
        static void Main(string[] args)
        {
			String gameName = "Super mario";
			Caretaker caretaker = new Caretaker();
			Originator originator = new Originator();

			Game game = new Game();
			game.setName(gameName);
			game.setCheckpoint(1);
			originator.setState(game);
			caretaker.addMemento(originator.save()); 
			Console.WriteLine("-----------State point one----------------");
			Console.WriteLine(game.toString());


			game = new Game();
			game.setName(gameName);
			game.setCheckpoint(2);
			originator.setState(game);
			caretaker.addMemento(originator.save()); 
			Console.WriteLine("-----------State point two----------------");
			Console.WriteLine(game.toString());

			game = new Game();
			game.setName(gameName);
			game.setCheckpoint(3);
			originator.setState(game);

			caretaker.addMemento(originator.save());
			Console.WriteLine("-----------State point three----------------");
			Console.WriteLine(game.toString());

			game = new Game();
			game.setName(gameName);
			game.setCheckpoint(4);

			originator.setState(game);
			caretaker.addMemento(originator.save());
			Console.WriteLine("-----------State point four----------------");
			Console.WriteLine(game.toString());

			game = new Game();
			game.setName(gameName);
			game.setCheckpoint(5);
			originator.setState(game);
			caretaker.addMemento(originator.save());
			Console.WriteLine("-----------State point five----------------");
			Console.WriteLine(game.toString());

			originator.setState(game);
			originator.restore(caretaker.getMemento(0));
			Console.WriteLine("-----------ohhhhhhh you lost----------------");
			Console.WriteLine("-----------Your new state is----------------");
			game = originator.getState();
			Console.WriteLine(game.toString());
			
			Console.WriteLine(game);
		}
    }
}
