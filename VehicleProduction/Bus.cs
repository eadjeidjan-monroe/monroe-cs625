using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProduction
{
	public class Bus: IVehicle
	{
		public int Height { get; set; }
		public int Width { get; set; }
		public double Weight { get; set; }
		public string Color { get; set; }
		public string MoveForward()
		{
			return "this bus is moving forward slowly";
		}

		public string MoveReverse()
		{
			return "reverse with sound";
		}

		public string HonkHorn()
		{
			return "paaaa paaa paaaa";
		}
	}
}
