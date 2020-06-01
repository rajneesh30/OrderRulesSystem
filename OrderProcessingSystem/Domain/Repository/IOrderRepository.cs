using Order.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Domain.Repository
{
    public interface IOrderRepository
    {
		Task<Order.Domain.Model.Order> GetAsync(Guid id);
		Task<IEnumerable<Order.Domain.Model.Order>> BrowseAsync();
		Order.Domain.Model.Order AddAsync(Order.Domain.Model.Order order);
	}
}
