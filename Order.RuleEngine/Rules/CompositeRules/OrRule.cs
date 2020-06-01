using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.RuleEngine.Rules.CompositeRules
{
    public class OrRule : IRule
    {
		private readonly IRule[] rules;

		public OrRule(params IRule[] rules)
		{
			this.rules = rules;
		}

		public bool IsSatisfied(Order.Domain.Model.Order order)
		{
			return this.rules.Any(r => r.IsSatisfied(order));
		}
	}
}
