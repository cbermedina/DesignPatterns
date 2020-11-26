namespace DesignPatterns.AbstractFactory.IService
{
    using System;
    public interface IFabricaAbstractaService
    {
        IConexionBDService getBD(String motor);
        IConexionRESTService getREST(String area);
    }
}
