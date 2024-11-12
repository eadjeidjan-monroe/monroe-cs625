using EntityF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF
{
	public class EFDemo
	{

		public void AddCategory()
		{
			var category = new Category()
			{
				CategoryId = 9,
				CategoryDescription = "Our new description",
				CategoryName = "Our Category Name"
			};
			using (var dbContext = new NorthwindDB())
			{
				dbContext.Categories.Add(category);
				dbContext.SaveChanges();

			}
		}

		public void UpdateCategory()
		{
			var category = new Category() { CategoryId = 5, CategoryDescription = "this is a test desc" };
			using (var dbContext = new NorthwindDB())
			{
				dbContext.Categories.Update(category);
			}
		}

		public void ListProducts()
		{
			using (var dbContext = new NorthwindDB())
			{
				foreach (var product in dbContext.Products)
				{
					Console.WriteLine($"{product.ProductID} {product.ProductName} {product.Price } ");
				}
			}
		}
	}
}
