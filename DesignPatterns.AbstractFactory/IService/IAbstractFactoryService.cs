namespace DesignPatterns.AbstractFactory.IService
{
    using System;
    public interface IAbstractFactoryService
    {
        IConexionBDService getBD(String motor);
        IConexionRESTService getREST(String area);
    }
}
