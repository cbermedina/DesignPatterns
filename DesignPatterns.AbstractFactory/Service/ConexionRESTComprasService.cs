namespace DesignPatterns.AbstractFactory.Service
{
    using DesignPatterns.AbstractFactory.IService;
    using System;
    class ConexionRESTComprasService : IConexionRESTService
    {
        public  void leerURL(String url)
        {
            Console.WriteLine($"Conectándose a {url}");
        }
    }
}
