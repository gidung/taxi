using System;
namespace LatihanClassDanObject
{
	class Program
	{
		static void Main(string[] args)
		{
			Taxi taxi = new Taxi();

			taxi.DriverName = "Hadi Miftahul Huda";
			taxi.OnDuty = true;
			taxi.NumPassenger = 10;

			taxi.TaxiInfo();
			taxi.PickupPassenger();
			taxi.DropOffPassenger();

			Console.ReadKey();
		}

	}
}