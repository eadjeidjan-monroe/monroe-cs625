using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProduction
{
	public class MercedesEClass: Car
	{
		public bool HeatedSeats { get; set; } = true;
		public bool MobileApp { get; set; } = true;

		public void LaneAssist()
		{
			Console.WriteLine("This is my Beautiful Lane Assist Feature");
		}

		public bool RemoteLock(bool lockDoors)
		{
			return !lockDoors;
		}

		public void CarLocation()
		{
			Console.WriteLine("Hey I am located here, check your maps");
		}


	}
}
