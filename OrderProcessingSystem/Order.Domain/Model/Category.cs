using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Model
{
    public class Category
    {
		public Guid Id { get; protected set; }		
		public string Name { get; protected set; }
		public string Description { get; protected set; }

		public Category()
		{

		}

		public Category(string name, string desc)
		{
			Id = Guid.NewGuid();
			Name = name;
			Description = desc;
		}
	}
}
