using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProduction
{
	public abstract class Train
	{
		public void MoveForward()
		{
			Console.WriteLine("I am moving on the train tracks");
		}
	}
}
