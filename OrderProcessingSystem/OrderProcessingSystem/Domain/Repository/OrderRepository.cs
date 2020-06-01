using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingSystem.Common;
using Order.Domain.Model;

namespace OrderProcessingSystem.Domain.Repository
{
	public class OrderRepository : IOrderRepository
	{
		private readonly OrderManagementContext _context;

		public OrderRepository(OrderManagementContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public Order.Domain.Model.Order AddAsync(Order.Domain.Model.Order order)
		{
			var entity = _context.Orders.Add(order).Entity;
			_context.SaveChanges();
			return entity;
		}

		public async Task<IEnumerable<Order.Domain.Model.Order>> BrowseAsync()
		{
			return _context.Orders.AsQueryable().ToList();
		}

		public async Task<Order.Domain.Model.Order> GetAsync(Guid id)
		{
			return  _context.Orders.AsQueryable().FirstOrDefault(x => x.Id == id);
		}
	}
}
