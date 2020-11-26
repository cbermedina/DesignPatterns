namespace DesignPatterns.Observer
{
	using DesignPatterns.Observer.Classes;
	using DesignPatterns.Observer.Observer;
	using System;
	class Program
    {
        static void Main(string[] args)
        {
			Subject subject = new Subject();

			new SolObserver(subject);
			new PesoARGObserver(subject);
			new PesoMXObserver(subject);

			Console.WriteLine("Si desea cambiar 10 dólares obtendrá : ");
			subject.setState(10);
			Console.WriteLine("-----------------");
			Console.WriteLine("Si desea cambiar 100 dólares obtendrá : ");
			subject.setState(100);
		}
    }
}
