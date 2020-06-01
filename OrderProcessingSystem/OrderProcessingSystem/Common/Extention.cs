using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Order.RuleEngine.Services;
using OrderProcessingSystem.Domain.Repository;
using OrderProcessingSystem.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem.Common
{
    public static class Extention 
	{
		/// <summary>
		/// Extention method to setup database connection
		/// </summary>
		/// <param name="services">app service object</param>
		/// <param name="Configuration">app configuration object</param>
		public static void DatabaseSetting(this IServiceCollection services, IConfiguration Configuration)
		{
			services.AddDbContext<OrderManagementContext>(options =>
			options.UseSqlServer(Configuration.GetConnectionString("OrderManagementContext")));
		}

		/// <summary>
		/// Extention method to setup domain entities
		/// </summary>
		/// <param name="services"></param>
		public static void OrderProcessingContracts(this IServiceCollection services)
		{
			services.AddSingleton<IOrderRepository, OrderRepository>();
			services.AddSingleton<ICategoryRepository, CategoryRepository>();
			services.AddSingleton<IProductRepository, ProductRepository>();
			services.AddSingleton<IOrderProviderService, OrderProviderService>();
			services.AddSingleton<IRuleService, RuleService>();
		}


	}
}
