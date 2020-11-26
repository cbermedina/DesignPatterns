namespace DesignPatterns.AbstractFactory.Service
{
    using DesignPatterns.AbstractFactory.IService;
    using System;
    public class ConexionOracleService : IConexionBDService
    {
        private String host;
        private String puerto;
        private String usuario;
        private String contrasena;

        public ConexionOracleService()
        {
            this.host = "localhost";
            this.puerto = "1521";
            this.usuario = "admin";
            this.contrasena = "123";
        }
        public  void conectar()
        {
            // Aqui puede ir código JDBC
            Console.WriteLine("Se conectó a Oracle");
        }
        public  void desconectar()
        {
            Console.WriteLine("Se desconectó de Oracle");
        }
        public  String toString()
        {
            return $"ConexionOracle [host={host}, puerto={puerto}, usuario={usuario}, contrasena={contrasena}]";
        }
    }
}
