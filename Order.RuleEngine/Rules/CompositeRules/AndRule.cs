using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.RuleEngine.Rules.CompositeRules
{
    public class AndRule : IRule
    {
		private readonly IRule[] rules;

		public AndRule(IRule[] rules)
		{
			this.rules = rules;
		}

		public bool IsSatisfied(Order.Domain.Model.Order order)
		{
			return this.rules.All(r => r.IsSatisfied(order));
		}
	}
}
