namespace DesignPatterns.Strategy.Service
{
    using System;
    using System.Threading;
    public class SimpleAntivirusService : SimpleAnalysis
    {
        public override void start()
        {
            Console.WriteLine("Antivirus Simple - Análisis simple iniciado");
        }

        public override void jumpZip()
        {
            Console.WriteLine("Analizando...");
            Thread.Sleep(2500);
            Console.WriteLine("No se pudo analizar archivos con extensión '.zip'");
        }
        public override void stop()
        {
            Console.WriteLine("Antivirus Simple - Análisis simple finalizado");
        }
    }
}
