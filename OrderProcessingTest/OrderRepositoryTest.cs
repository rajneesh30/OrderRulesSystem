using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderProcessingSystem.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingTest
{
	[TestClass]
	class OrderRepositoryTest
    {
		[TestMethod]
		public void GetById_Returns_Order()
		{
			var mockProdRepo = new Mock<IOrderRepository>();
			var objOrder = new Order.Domain.Model.Order("testby", "testProd", "testCat");
			mockProdRepo.Setup(p => p.GetAsync(Guid.NewGuid())).ReturnsAsync(objOrder);

			var result = mockProdRepo.Object.GetAsync(objOrder.Id);
			Assert.AreEqual(objOrder, result);
		}
	}
}
