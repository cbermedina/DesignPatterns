namespace DesignPatterns.AbstractFactory.Service.Fabrica
{
    using DesignPatterns.AbstractFactory.IService;
    using System;
    public class FactoryProducerService
    {
        public static IAbstractFactoryService getFactory(String factoryType)
        {
            if (factoryType.Equals("BD"))
            {
                return new ConexionBDFabricaService();

            }
            else if (factoryType.Equals("REST"))
            {
                return new ConexionRESTFabricaService();
            }
            return null;
        }
    }
}
