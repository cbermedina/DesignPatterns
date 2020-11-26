namespace DesignPatterns.AbstractFactory.Service
{
    using DesignPatterns.AbstractFactory.IService;
    using System;
    public class ConexionVaciaService : IConexionBDService
    {
        public  void conectar()
        {
            Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
        }
        public  void desconectar()
        {
            Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
        }
    }
}
