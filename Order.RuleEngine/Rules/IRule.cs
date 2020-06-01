using System;
using System.Collections.Generic;
using System.Text;


namespace Order.RuleEngine.Rules
{
    public interface IRule
    {
		bool IsSatisfied(Order.Domain.Model.Order order);
    }
}
