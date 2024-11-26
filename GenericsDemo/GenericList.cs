using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
	public class GenericList<T>
	{

		public void Add<T>(T item)
		{
			Console.WriteLine($"{item} has a data type {item.GetType().ToString()}");
		}
	}
}
