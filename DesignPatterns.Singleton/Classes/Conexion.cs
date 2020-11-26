using System;

namespace DesignPatterns.Singleton.Classes
{
    public class Conexion
    {

        //Declaración
        private static Conexion instancia;
        //private static Conexion instancia = new Conexion();

        //Para evitar instancia mediante operador "new"
        private Conexion()
        {

        }

        //Para obtener la instancia unicamente por este metodo
        //Notese la palabra reservada "static" hace posible el acceso mediante Clase.metodo
        public static Conexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        //Método de prueba
        public void conectar()
        {
            Console.WriteLine("Me conecté a la BD");
        }

        //Método de prueba
        public void desconectar()
        {
            Console.WriteLine("Me desconecté de la BD");
        }
    }
}
