using System;
using System.Collections.Generic;
using System.Text;

namespace Order.RuleEngine.Rules
{
    public class UpgradeMembershipRule : IRule
    {
		public bool IsSatisfied(Order.Domain.Model.Order order)
		{
			if (order.Category == CategoryTypes.Category.MembershipUpgrade.ToString())
			{
				Console.WriteLine("Applied the upgrade and e-mailed the owner and informed them of the activation/upgrade...");
			}

			return true;
		}
	}
}
