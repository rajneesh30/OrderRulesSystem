using Order.Domain.Model;
using OrderProcessingSystem.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Order.RuleEngine.Rules.Helpers;
using Order.RuleEngine.Rules;
using Order.RuleEngine.Services;

namespace OrderProcessingSystem.Services
{
	class OrderProviderService : IOrderProviderService
	{
		private readonly IOrderRepository _orderRepository;
		private readonly ICategoryRepository _categoryRepository;
		private readonly IProductRepository _productRepository;
		private readonly IRuleService _ruleService;

		/// <summary>
		/// Constructor for OrderProcessingSystem that accepts 3 paramaeters through dependency injection
		/// </summary>
		/// <param name="orderRepository"></param>
		/// <param name="categoryRepository"></param>
		/// <param name="productRepository"></param>
		/// <param name="ruleService"></param>
		public OrderProviderService(IOrderRepository orderRepository, ICategoryRepository categoryRepository, IProductRepository productRepository, IRuleService ruleService)
		{
			_orderRepository = orderRepository;
			_categoryRepository = categoryRepository;
			_productRepository = productRepository;
			_ruleService = ruleService;
		}
		/// <summary>
		/// Order processing method add order in DB
		/// </summary>
		/// <param name="id"></param>
		/// <param name="userId"></param>
		/// <param name="category"></param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		/// <param name="createdAt"></param>
		/// <returns></returns>
		public Order.Domain.Model.Order AddOrder(Guid id, Guid userId, Guid category, string name, string description, DateTime createdAt)
		{
			var productDetail =  _productRepository.Get(id);
			var categoryDetail = _categoryRepository.Get(category);
			if (productDetail == null || categoryDetail == null)
			{
				throw new Exception("product or category_not_found");
			}
			var order = new Order.Domain.Model.Order(name, productDetail.Name, categoryDetail.Name);
			EvaluateforBusinessRules(order);
			return  _orderRepository.AddAsync(order);
		}

		private void EvaluateforBusinessRules(Order.Domain.Model.Order order)
		{
			if (order.Category == "Book" || order.Category == "PhysicalProduct")
			{
				var rule =
					RuleHelper.Or(
					new IRule[2] {  new BookProductRule(), new PhysicalProductRule() });
				
				_ruleService.Evaluate(rule, order);
			}

			if (order.Category == "Membership" || order.Category == "MembershipUpgrade")
			{
				var rule =
					RuleHelper.Or(
					new IRule[2] { new MembershipProductRule(), new UpgradeMembershipRule() });
				
				_ruleService.Evaluate(rule, order);
			}

		}
	}
}
