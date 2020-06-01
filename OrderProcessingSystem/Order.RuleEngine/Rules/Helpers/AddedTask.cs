using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Order.RuleEngine.Rules.Helpers
{
    public class AddedTask
    {
		private readonly IRule[] _rules;

		public AddedTask(IRule[] rules)
		{
			this._rules = rules;
		}

		public void BookorPhysicalProduct()
		{
			Console.WriteLine("Perform additional task..");
		}
    }
}
