namespace DesignPatterns.Strategy.Service
{
    using System;
    using System.Threading;
    public class AdvancedAntivirusService : AdvancedAnalysis
    {
       public override void start()
        {
            Console.WriteLine("Antivirus Avanzado - Análisis simple iniciado");
        }


        public override void analyzeMemory()
        {
            Console.WriteLine("Analizando Memoria RAM...");
            Thread.Sleep(1000);
        }

        public override void analyzeKeyloggers()
        {
            Console.WriteLine("Analizando en busca de Keyloggers...");
            Thread.Sleep(1000);
        }
        public  override void analyzeRootKits()
        {
            Console.WriteLine("Analizando en busca de RootKits...");
            Thread.Sleep(1500);
        }
        public override void unZip()
        {
            Console.WriteLine("Analizando archivos zip...");
            Thread.Sleep(2000);
        }
        public override void stop()
        {
            Console.WriteLine("Antivirus Avanzado - Análisis simple finalizado");
        }
    }
}
