using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF.Model
{
	public class Product
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public Supplier SupplierId { get; set; }
		public Category CategoryId { get; set; }
		public string Unit { get; set; }
		public decimal Price { get; set; }
		public Shipper ShipperId { get; set; }
	}
}
