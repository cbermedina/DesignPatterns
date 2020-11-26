namespace DesignPatterns.AbstractFactory.Service.Fabrica
{
    using DesignPatterns.AbstractFactory.IService;
    using System;
    public class ConexionBDFabricaService : IAbstractFactoryService
    {
        public  IConexionBDService getBD(String motor)
        {
            if (motor == null)
            {
                return new ConexionVaciaService();
            }
            if (motor.Equals("MYSQL"))
            {
                return new ConexionMySQLService();
            }
            else if (motor.Equals("ORACLE"))
            {
                return new ConexionOracleService();
            }
            else if (motor.Equals("POSTGRE"))
            {
                return new ConexionPostgreSQLService();
            }
            else if (motor.Equals("SQL"))
            {
                return new ConexionSQLServerService();
            }

            return new ConexionVaciaService();
        }
        public IConexionRESTService getREST(String area)
        {
            return null;
        }
    }
}
