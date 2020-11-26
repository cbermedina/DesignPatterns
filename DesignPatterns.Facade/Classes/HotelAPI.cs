namespace DesignPatterns.Facade.Classes
{
	using System;
	public class HotelAPI
    {
		public void searchHotel(String fechaEntrada, String fechaSalida, String origen, String destino)
		{
			Console.WriteLine("==============================");
			Console.WriteLine("Hoteles encontrados");
			Console.WriteLine($"Entrada: {fechaEntrada} Salida: {fechaSalida}");
			Console.WriteLine("Hotel A");
			Console.WriteLine("Hotel B");
			Console.WriteLine("Hotel C");
			Console.WriteLine("==============================");
		}
	}
}
