using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProduction
{
	public class MercedesCClass: Vehicle, IAirPlane
	{
		public void MoveForward()
		{
			Console.WriteLine("I'm moving sideways at time I'm moving forward");
		}

		public override void WarmSeats(string userInput)
		{
			Console.WriteLine("Hey I like my seats very " + userInput);
		}

		//public void WarmSeats()
		//{
		//	Console.WriteLine("I'm blowing cool air to give cool seats");
		//}
		public double SetAltitude(double altitude)
		{
			return altitude;
		}

		public string Fly()
		{
			return $"I am flying in the sky at an altitude of {SetAltitude(4500)}";
		}
	}
}
