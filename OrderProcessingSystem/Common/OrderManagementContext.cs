using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Order.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem.Common
{
    public class OrderManagementContext: DbContext
    {
		public OrderManagementContext(DbContextOptions<OrderManagementContext> options)
			: base(options)
		{

		}
		public DbSet<Order.Domain.Model.Order> Orders { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Category { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//entities' configuration ...
			//modelBuilder.HasDefaultSchema("OrderManagement");

			//Map entity to table
			modelBuilder.Entity<Order.Domain.Model.Order>().ToTable("Orders");
			modelBuilder.Entity<Product>().ToTable("Products", "dbo");
			modelBuilder.Entity<Category>().ToTable("Category", "dbo");
		}

		
		

	}
}
