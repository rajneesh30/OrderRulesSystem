using System;
using System.Collections.Generic;
using System.Text;
using Order.Domain.Model;

namespace Order.RuleEngine.Rules
{
	public class BookProductRule : IRule
	{
		public bool IsSatisfied(Order.Domain.Model.Order order)
		{
			if (order.Category == CategoryTypes.Category.Book.ToString())
			{
				Console.WriteLine("Duplicate packing slip for the royalty department has been sent and generated a commission payment to the agent..");

			}
				
			return true;
		}
	}
}
