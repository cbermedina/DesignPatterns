namespace DesignPatterns.AbstractFactory.Service.Fabrica
{
    using DesignPatterns.AbstractFactory.IService;
    using System;
    public class FactoryProducerService
    {
        public static IFabricaAbstractaService getFactory(String tipoFabrica)
        {
            if (tipoFabrica.Equals("BD"))
            {
                return new ConexionBDFabricaService();

            }
            else if (tipoFabrica.Equals("REST"))
            {
                return new ConexionRESTFabricaService();
            }
            return null;
        }

    }
}
