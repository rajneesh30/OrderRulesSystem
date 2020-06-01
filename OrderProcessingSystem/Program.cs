using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using OrderProcessingSystem.Services;
using System;

namespace OrderProcessingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OrderManagement!");

			IServiceCollection services = new ServiceCollection();
			// Startup.cs finally :)
			Startup startup = new Startup();
			startup.ConfigureServices(services);
			IServiceProvider serviceProvider = services.BuildServiceProvider();

			//configure console logging
			//serviceProvider
			//	.GetService<ILoggerFactory>()
			//	.AddConsole(LogLevel.Debug);

			

			var logger = serviceProvider.GetService<ILoggerFactory>()
				.CreateLogger<Program>();

			logger.LogDebug("Logger is working!");

			// Get Service and call method
			var service = serviceProvider.GetService<IOrderProviderService>();
			//service.AddOrder(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), "testname", "testdesc", DateTime.Now);
			service.AddOrder(new Guid("11826a6d-2572-4d5a-bb94-73e67b6b2f24"), new Guid("25fe8d8e-a337-4d08-a924-6e0ab331478e"),new Guid("c68afd74-267e-4154-a52d-c47ee9b7a54c"), "testorder", "testdesc", DateTime.Now);
			Console.ReadLine();
		}
	}
}
