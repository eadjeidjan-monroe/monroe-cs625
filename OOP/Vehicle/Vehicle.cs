using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
	public class Vehicle 
	{
		internal string Mileage;
		public string Color { get; set; }
		public double Height { get; set; }
		public double Width { get; set; }
		public double Weight { get; set; }
		public int NumberOfDoors { get; set; }

		public Vehicle()
		{
			Console.WriteLine("Hey I am the constructor. this is where the class starts. The first method");
		}

		public Vehicle(VehicleProps vehicleProps)
		{
			Color = vehicleProps.Color;
			Height = vehicleProps.Height;
			Width = vehicleProps.Width;
			Weight = vehicleProps.Weight;
			NumberOfDoors = vehicleProps.NumberOfDoors;

		}

		//public Vehicle(string color, double weight, int doors,  double witdth, double height)
		//{
		//	Color = color;
		//	Weight = weight;
		//}
		public void MoveFoward()
		{
			Console.WriteLine("Hey I am moving forward ....");
		}

		public void Reverse()
		{
			Console.WriteLine("Hey I am moving backward ....");
		}

		public void Honk()
		{

		}

		public void VehicleDescription()
		{
			Console.WriteLine($"this is a vehicle with a height of {Height} \n" +
			                  $", a width of {Width}, {Color} color \n" +
			                  $" and {NumberOfDoors} doors");
		}
	}
}
