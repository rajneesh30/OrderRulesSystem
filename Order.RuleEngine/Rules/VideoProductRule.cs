using System;
using System.Collections.Generic;
using System.Text;

namespace Order.RuleEngine.Rules
{
    public class VideoProductRule : IRule
    {
		public bool IsSatisfied(Order.Domain.Model.Order order)
		{
			if (order.Category == CategoryTypes.Category.Video.ToString())
			{
				Console.WriteLine("Added a free “First Aid” video to the packing slip.");
			}

			return true;
		}
	}
}
