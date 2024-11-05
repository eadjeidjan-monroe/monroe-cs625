using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF.Model
{
	public class Order
	{
		public int OrderId { get; set; }
		public Customer CustomerId { get; set; }
		public Employee EmployeeId { get; set; }
		public DateTime OrderDate { get; set; }
		public Shipper ShipperId { get; set; }
	}
}
