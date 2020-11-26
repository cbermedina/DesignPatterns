﻿namespace DesignPatterns.AbstractFactory.Service
{
    using DesignPatterns.AbstractFactory.IService;
    using System;
    public class ConexionVaciaService : IConexionBDService
    {
        public  void conect()
        {
            Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
        }
        public  void disconnect()
        {
            Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
        }
    }
}
