using System;
using System.Collections.Generic;
using System.Text;

namespace Order.RuleEngine.Rules
{
    public class PhysicalProductRule : IRule
    {
		public bool IsSatisfied(Order.Domain.Model.Order order)
		{
			if (order.Category == CategoryTypes.Category.PhysicalProduct.ToString())
			{
				Console.WriteLine("Generated a packing slip for shipping and generate a commission payment to the agent...");
			}

			return true;
		}

	}
}
