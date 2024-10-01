using System;
using System.Collections.Generic;
using Vehicle;

namespace VehicleEntryPoint
{
	internal class Program
	{
		static void Main(string[] args)
		{
			VehicleProps props = new VehicleProps()
			{
				Height = 1.4,
				Width = 1.1,
				NumberOfDoors = 2,
				Color = "Violet"
			};

			Vehicle.Vehicle newCar = new Vehicle.Vehicle(props);

			
			//newCar.Height = 1.4;
			//newCar.Width = 1.1;
			//newCar.NumberOfDoors = 2;
			newCar.VehicleDescription();
			Console.ReadLine();

			//List<Vehicle.Vehicle> vehicles = new List<Vehicle.Vehicle>();
			//vehicles.Add(new Vehicle.Vehicle()
			//{
			//	Color = "blue", 
			//	Height = 12,
			//	Width = 2,
			//	NumberOfDoors = 3,
			//	Weight = 800

			//});
			//vehicles.Add(new Vehicle.Vehicle()
			//{
			//	Color = "green",
			//	Height = 12,
			//	Width = 32,
			//	NumberOfDoors = 103,
			//	Weight = 700
			//});

			//vehicles.Add(new Vehicle.Vehicle()
			//{
			//	Color = "white",
			//	Height = 45,
			//	Width = 34,
			//	NumberOfDoors = 8,
			//	Weight = 3421
			//});
			//List<Vehicle.Vehicle> vehicles = new List<Vehicle.Vehicle>()
			//{
			//	new Vehicle.Vehicle()
			//	{
			//		Color = "blue",
			//		Height = 12,
			//		Width = 2,
			//		NumberOfDoors = 3,
			//		Weight = 800
			//	},
			//	new Vehicle.Vehicle()
			//	{
			//			Color = "white",
			//			Height = 45,
			//			Width = 34,
			//			NumberOfDoors = 8,
			//			Weight = 3421
			//	},
			//	new Vehicle.Vehicle()
			//	{
			//			Color = "green",
			//			Height = 12,
			//			Width = 32,
			//			NumberOfDoors = 103,
			//			Weight = 700
			//	}

			//};

			//foreach (var vehicle in vehicles)
			//{
			//	Console.WriteLine($"{vehicle.Color}");
			//}

			Console.ReadLine();
		}
	}
}
