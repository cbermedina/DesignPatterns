namespace DesignPatterns.Factory.Service
{
	using DesignPatterns.Factory.IService;
	using System;
	public class ConexionFactoryService
	{
		public IConexionBDService getConexion(String motor)
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
	}
}
