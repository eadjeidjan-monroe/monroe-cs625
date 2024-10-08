using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackLibrary
{
	public class Person
	{
		#region Properties

		public String? Name { get; set; }
		public DateTimeOffset Born { get; set; }
		public List<Person> Children = new();

		//Allow multiple spouses to be stored for a person
		public List<Person> Spouses = new();

		//A readonly field to show is a person is married to anyone
		public bool Married => Spouses.Count > 0;

		//public bool Married()
		//{
		//	return Spouses.Count > 0; // same as above
		//}

		#endregion

		#region Methods

		public void WriteToConsole()
		{
			Console.WriteLine($"{Name} was born on a {Born:dddd}");
		}

		public void WriteChildrenToConsole()
		{
			string term = Children.Count == 1 ? "child" : "children";
			Console.WriteLine($"{Name} has {Children.Count} {term}.");
		}

		//static method to marry two people
		public static void Marry(Person p1, Person p2)
		{
			ArgumentNullException.ThrowIfNull(p1);
			ArgumentNullException.ThrowIfNull(p2);

			if (p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
			{
				throw new ArgumentException(string.Format("{0} is already married to {1}.", arg0:p1.Name, arg1: p2.Name));
			}

			p1.Spouses.Add(p2);
			p2.Spouses.Add(p1);
		}

		public void Marry(Person partner)
		{
			Marry(this, partner); //this; --> current person
		}

		public void OutputSpouses()
		{
			if(Married)
			{
				string term = Spouses.Count == 1 ? "person" : "people";
				Console.WriteLine($"{Name} is married to {Spouses.Count} {term}:");

				foreach (var spouse in Spouses)
				{
					Console.WriteLine($"{spouse.Name}");
				}
			}
			else
			{
				Console.WriteLine($"{Name} is single.");
			}
		}

		//procreate
		public static Person Procreate(Person p1, Person p2)
		{
			ArgumentNullException.ThrowIfNull(p1);
			ArgumentNullException.ThrowIfNull(p2);
			if (!p1.Spouses.Contains(p2) && p2.Spouses.Contains(p1))
			{
				throw new ArgumentException(string.Format("{0} must be married to {1} to procreate with them.",
					arg0: p1.Name, arg1: p2.Name));
			}

			Person baby = new()
			{
				Name = $"Baby of {p1.Name} and {p2.Name}",
				Born = DateTimeOffset.Now
			};

			p1.Children.Add(baby);
			p2.Children.Add(baby);

			return baby;
		}

		//instance method for procreate
		public Person ProcreateWith(Person partner)
		{
			return Procreate(this, partner);
		}

		//ASSIGNMENT
		//1. implement methods that will check if a married couple has kids, and if not let them adopt kids
		//2. Also implement isStepChild method / property, that will check if a baby is a stepchild 
		//3. Implement the parents method to show parents of a baby.
		//Show code output
		#endregion

		#region Operators

		//Define the + operator to marry
		public static bool operator +(Person a, Person b)
		{
			Marry(a, b);

			return a.Married && b.Married;
		}

		//define the * operator to procreate (multiply)
		public static Person operator *(Person a, Person b)
		{
			//return a ref to the baby that results from 'multiplying'
			return Procreate(a, b);
		}

		#endregion
	}
}
