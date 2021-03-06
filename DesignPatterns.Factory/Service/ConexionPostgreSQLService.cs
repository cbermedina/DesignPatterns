﻿namespace DesignPatterns.Factory.Service
{
    using DesignPatterns.Factory.IService;
    using System;
    public class ConexionPostgreSQLService : IConexionBDService
    {
        private String host;
        private String puerto;
        private String usuario;
        private String contrasena;

        public ConexionPostgreSQLService()
        {
            this.host = "localhost";
            this.puerto = "5433";
            this.usuario = "postgres";
            this.contrasena = "123";
        }
        public  void conect()
        {
            // Aqui puede ir código JDBC
            Console.WriteLine("Se conectó a PostgreSQL");
        }
        public  void disconnect()
        {
            Console.WriteLine("Se desconectó de PostgreSQL");
        }
        public  String toString()
        {
            return $"ConexionPostgreSQL [host={host}, puerto={puerto}, usuario={usuario}, contrasena={contrasena}]";
        }
    }
}
