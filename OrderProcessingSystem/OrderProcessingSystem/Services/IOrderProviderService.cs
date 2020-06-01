using Order.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Services
{
	/// <summary>
	/// Service endpoint to client
	/// </summary>
    public interface IOrderProviderService
    {
		Order.Domain.Model.Order AddOrder(Guid id, Guid userId, Guid category,
			string name, string description, DateTime createdAt);
	}
}
