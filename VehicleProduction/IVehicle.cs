using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProduction
{
	public interface  IVehicle
	{
		public int  Height { get; set; }
		public int Width { get; set; }
		public double Weight { get; set; }
		public string Color {get; set;}
		public  string MoveForward();
		public  string MoveReverse();
		public string HonkHorn();
	}
}
