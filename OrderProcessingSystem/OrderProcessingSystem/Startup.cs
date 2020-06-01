using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using OrderProcessingSystem.Common;
using Order.Domain.Model;
using OrderProcessingSystem.Domain.Repository;
using OrderProcessingSystem.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OrderProcessingSystem
{
    public class Startup
    {
		IConfigurationRoot Configuration { get; }

		public Startup()
		{
			var builder = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", true,true);

			Configuration = builder.Build();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddLogging();
			services.AddSingleton<IConfigurationRoot>(Configuration);			

			//contains "Server=xxxxxx"
			string dbConn = Configuration.GetSection("ConnectionStrings").GetSection("OrderManagementContext").Value;

			//var connectionString = Configuration.GetConnectionString("OrderManagementContext");
			services.DatabaseSetting(Configuration);
			services.OrderProcessingContracts();			
		}
		
	}
	
}
