using Order.RuleEngine.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.RuleEngine.Services
{
    public interface IRuleService
    {
		bool Evaluate(IRule rule, Order.Domain.Model.Order order);
	}
}
