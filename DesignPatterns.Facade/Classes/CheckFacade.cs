namespace DesignPatterns.Facade.Classes
{
	using System;
	public class CheckFacade
    {
		private FlightAPI avionAPI;
		private HotelAPI hotelAPI;

		public CheckFacade()
		{
			avionAPI = new FlightAPI();
			hotelAPI = new HotelAPI();
		}
		public void search(String fechaIda, String fechaVuelta, String origen, String destino)
		{
			avionAPI.searchFlights(fechaIda, fechaVuelta, origen, destino);
			hotelAPI.searchHotel(fechaIda, fechaVuelta, origen, destino);
		}
	}
}
