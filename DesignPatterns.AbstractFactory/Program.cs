namespace DesignPatterns.AbstractFactory
{
    using DesignPatterns.AbstractFactory.IService;
    using DesignPatterns.AbstractFactory.Service.Fabrica;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IAbstractFactoryService fabricaBD = FactoryProducerService.getFactory("BD");
            IConexionBDService cxBD1 = fabricaBD.getBD("MYSQL");

            cxBD1.conect();

            IAbstractFactoryService fabricaREST = FactoryProducerService.getFactory("REST");
            IConexionRESTService cxRS1 = fabricaREST.getREST("COMPRAS");

            cxRS1.leerURL("https://www.myurl?id=10");
        }
    }
}
