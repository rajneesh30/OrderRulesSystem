using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Model
{
    public class Order
    {
		public Guid Id { get; protected set; }		
		public string OrderBy { get;  set; }
		public string Product { get;  set; }
		public string Category { get;  set; }
		public DateTime CreatedAt { get;  set; }

		protected Order()
		{
		}

		public Order(string orderby, string product, string category)
		{
			Id = Guid.NewGuid(); 
			OrderBy = orderby;
			Product = product;
			Category = category;
			CreatedAt = DateTime.UtcNow;
		}
	}
}
