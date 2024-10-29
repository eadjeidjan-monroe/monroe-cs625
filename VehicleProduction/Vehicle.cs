using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProduction
{
	public abstract class Vehicle
	{

		public void MoveForward()
		{
			Console.WriteLine("I am moving forward");
		}

		public void MoveReverse()
		{
			Console.WriteLine("I am moving in the reverse direction");
		}

		public abstract void WarmSeats(string userInput);
		//{
		//	//Console.WriteLine("I'm here to warm you in winter with hot air");
		//}
	}
}
