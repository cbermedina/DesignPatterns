namespace DesignPatterns.Factory
{
    using DesignPatterns.Factory.IService;
    using DesignPatterns.Factory.Service;
    class Program
    {
        static void Main(string[] args)
        {
			ConexionFactoryService factory = new ConexionFactoryService();

			IConexionBDService cx1 = factory.getConexion("ORACLE");
			cx1.conect();
			cx1.disconnect();

			IConexionBDService cx2 = factory.getConexion("MYSQL");
			cx2.conect();
			cx2.disconnect();

			IConexionBDService cx3 = factory.getConexion("H2");
			cx3.conect();
			cx3.disconnect();
		}
    }
}
