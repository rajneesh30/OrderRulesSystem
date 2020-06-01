using System;
using System.Collections.Generic;
using System.Text;
using Order.RuleEngine.Rules;


namespace Order.RuleEngine.Services
{
	public class RuleService : IRuleService
	{
		public bool Evaluate(IRule rule, Order.Domain.Model.Order order)
		{
			return rule.IsSatisfied(order);
		}
	}
}
