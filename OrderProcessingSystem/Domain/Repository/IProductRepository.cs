using Order.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Domain.Repository
{
    public interface IProductRepository
    {
		Product Get(Guid id);
		IEnumerable<Product> Browse();
		Product Add(Product product);
	}
}
