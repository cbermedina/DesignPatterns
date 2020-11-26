namespace DesignPatterns.Strategy
{
    using DesignPatterns.Strategy.Classes;
    using DesignPatterns.Strategy.Service;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Start Advanced Antivirus-----");
            Context context = new Context(new AdvancedAntivirusService());
            context.execute();
            Console.WriteLine("-----End Advanced Antivirus-----");
            Console.WriteLine("//-------------------------------------//");
            Console.WriteLine("-----Start Simple Antivirus-----");
            Context contextoSimple = new Context(new SimpleAntivirusService());
            contextoSimple.execute();
            Console.WriteLine("-----End Simple Antivirus-----");
        }
    }
}
