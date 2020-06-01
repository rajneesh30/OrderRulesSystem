using Order.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Domain.Repository
{
    public interface ICategoryRepository
    {
		Category Get(Guid id);
		IEnumerable<Category> Browse();
		Category Add(Category product);
	}
}
