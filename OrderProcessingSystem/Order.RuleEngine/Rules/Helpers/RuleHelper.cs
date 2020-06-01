using Order.RuleEngine.Rules.CompositeRules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.RuleEngine.Rules.Helpers
{
    public static class RuleHelper
    {
		public static IRule And(IRule[] rules)
		{			
			return new AndRule(rules);
		}

		public static IRule Or(IRule[] rules)
		{			
			return new OrRule(rules);
		}
	}
}
