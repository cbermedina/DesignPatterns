namespace DesignPatterns.AbstractFactory.Service.Fabrica
{
    using DesignPatterns.AbstractFactory.IService;
    using System;
    public class ConexionRESTFabricaService : IFabricaAbstractaService
    {
        public IConexionRESTService getREST(String area)
        {
            if (area == null)
            {
                return new ConexionRESTNoAreaService();
            }
            if (area.Equals("COMPRAS"))
            {
                return new ConexionRESTComprasService();
            }
            else if (area.Equals("VENTAS"))
            {
                return new ConexionRESTVentasService();
            }
            return new ConexionRESTNoAreaService();
        }
        public  IConexionBDService getBD(String motor)
        {
            return null;
        }
    }
}
