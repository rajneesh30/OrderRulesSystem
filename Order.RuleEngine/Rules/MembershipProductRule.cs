using System;
using System.Collections.Generic;
using System.Text;

namespace Order.RuleEngine.Rules
{
    public class MembershipProductRule : IRule
    {
		public bool IsSatisfied(Order.Domain.Model.Order order)
		{
			if (order.Category == CategoryTypes.Category.Membership.ToString())
			{
				Console.WriteLine("Activated that membership and e-mailed the owner and inform them of the activation/upgrade...");
			}

			return true;
		}
	}
}
