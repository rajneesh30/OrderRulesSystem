using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingSystem.Common;
using Order.Domain.Model;

namespace OrderProcessingSystem.Domain.Repository
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly OrderManagementContext _context;

		public CategoryRepository(OrderManagementContext context)
		{
			_context = context;
		}

		public IEnumerable<Category> Browse()
		{
			return _context.Category.AsQueryable().ToList();
		}		

		public Category Get(Guid id)
		{
			return _context.Category.AsQueryable().FirstOrDefault(x => x.Id == id);
		}

		public Category Add(Category category)
		{
			return _context.Category.Add(category).Entity;
		}
		
	}
}
