namespace DesignPatterns.Factory.Service
{
    using DesignPatterns.Factory.IService;
    using System;
    public class ConexionSQLServerService : IConexionBDService
    {
        private String host;
        private String port;
        private String user;
        private String password;

        public ConexionSQLServerService()
        {
            this.host = "localhost";
            this.port = "1433";
            this.user = "postgres";
            this.password = "123";
        }
        public  void conect()
        {
            // Aqui puede ir código JDBC
            Console.WriteLine("Se conectó a SQLServer");
        }
        public  void disconnect()
        {
            Console.WriteLine("Se desconectó de SQLServer");
        }
        public String getHost()
        {
            return host;
        }
        public void setHost(String host)
        {
            this.host = host;
        }
        public String getPort()
        {
            return port;
        }
        public void setPort(String puerto)
        {
            this.port = puerto;
        }
        public String getUser()
        {
            return user;
        }
        public void setUser(String usuario)
        {
            this.user = usuario;
        }
        public String getPassword()
        {
            return password;
        }
        public void setPassword(String contrasena)
        {
            this.password = contrasena;
        }
    }
}
