using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProduction;

namespace VehicleProduction
{
	public class Car:IVehicle
	{
		public int Height { get; set; }
		public int Width { get; set; }
		public double Weight { get; set; }
		public string Color { get; set; }
		public string MoveForward()
		{
			return "moving forward";
		}

		public string MoveReverse()
		{
			return "car is reversing";
		}

		public string HonkHorn()
		{
			return "piiii piii piiii";
		}
	}
}
