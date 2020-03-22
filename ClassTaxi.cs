using System;
namespace LatihanClassDanObject
{
	public class Taxi
	{
		public string DriverName { get; set; }
		public bool OnDuty = true;
		public int NumPassenger { get; set; }

		public void TaxiInfo()
		{
			Console.WriteLine("Driver Name: {0}", DriverName);
			Console.Write("On Duty: ");
			Console.WriteLine(OnDuty ? "Yes" : "No");
			Console.WriteLine("Num of Passenger: {0}", NumPassenger);
			
		}

		public void PickupPassenger()
		{
			Console.WriteLine("{0} Sedang Menjemput Penumpang ", DriverName);
		}

		public void DropOffPassenger()
		{
			Console.WriteLine("{0} Selesai Mengantar Penumpang ", DriverName);
		}

	}
}