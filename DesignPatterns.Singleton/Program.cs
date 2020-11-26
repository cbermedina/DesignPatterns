namespace DesignPatterns.Singleton
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciación por constructor prohíbido por ser "private"
            Classes.Conexion conexion = Classes.Conexion.getInstancia();
            conexion.conectar();
            conexion.desconectar();
            var classType = typeof(Classes.Conexion);
            bool rpta = classType.IsInstanceOfType(conexion);
            Console.WriteLine(rpta);
        }
    }
}
