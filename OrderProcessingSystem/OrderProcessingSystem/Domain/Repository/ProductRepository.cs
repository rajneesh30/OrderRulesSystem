using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingSystem.Common;
using Order.Domain.Model;

namespace OrderProcessingSystem.Domain.Repository
{

	public class ProductRepository : IProductRepository
	{
		private readonly OrderManagementContext _context;

		public ProductRepository(OrderManagementContext context)
		{
			_context = context;
		}
		public Product Add(Product product)
		{
			return _context.Products.Add(product).Entity;
		}

		public IEnumerable<Product> Browse()
		{
			return _context.Products.AsQueryable().ToList();
		}

		public Product Get(Guid id)
		{
			return _context.Products.AsQueryable().FirstOrDefault(x => x.Id == id);
		}
	}
}
