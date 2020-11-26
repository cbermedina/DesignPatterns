namespace DesignPatterns.Facade
{
    using DesignPatterns.Facade.Classes;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CheckFacade cliente1 = new CheckFacade();
            cliente1.search("02/07/2021", "08/07/2021", "Colombia", "Cancún");

            CheckFacade cliente2 = new CheckFacade();
            cliente2.search("02/07/2021", "08/07/2021", "Colombia", "Quito");
        }
    }
}
