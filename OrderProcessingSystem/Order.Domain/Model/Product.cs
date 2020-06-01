using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Model
{
    public class Product
    {
		public Guid Id { get; protected set; }
		public string Category { get; protected set; }		
		public string Name { get; protected set; }
		public string Description { get; protected set; }
		public Decimal Price { get; protected set; }


		protected Product()
		{
		}

		public Product( string category, string name, string desc, decimal price)
		{
			Id = Guid.NewGuid();
			Category = category;
			Name = name;
			Description = desc;
			Price = price;
		}
	}
}
