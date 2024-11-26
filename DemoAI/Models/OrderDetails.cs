using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF.Model
{
	public class OrderDetails
	{
		public int OrderDetailID { get; set; }
		public Order OrderID { get; set; }
		public Product ProductId { get; set; }
		public int Quantity { get; set; }


	}
}
