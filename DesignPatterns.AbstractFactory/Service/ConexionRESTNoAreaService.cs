namespace DesignPatterns.AbstractFactory.Service
{
    using DesignPatterns.AbstractFactory.IService;
    using System;
    class ConexionRESTNoAreaService : IConexionRESTService
    {
        public  void leerURL(String url)
        {
            Console.WriteLine("AREA NO ELEGIDA");
        }
    }
}
