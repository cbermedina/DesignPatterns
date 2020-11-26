namespace DesignPatterns.Facade.Classes
{
    using System;
    public class FlightAPI
    {
        public void searchFlights(String fechaIda, String fechaVuelta, String origen, String destino)
        {
            Console.WriteLine("==============================");
            Console.WriteLine($"Vuelos encontrados para {destino} desde {origen}");
            Console.WriteLine($"Fecha IDA: {fechaIda} Fecha Vuelta {fechaVuelta}");
            Console.WriteLine("==============================");
        }
    }
}
