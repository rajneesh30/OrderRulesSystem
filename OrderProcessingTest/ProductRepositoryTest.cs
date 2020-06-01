using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Order.Domain.Model;
using OrderProcessingSystem.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingTest
{
	[TestClass]
    class ProductRepositoryTest
    {
		
		[TestMethod]
		public void GetById_Returns_Product()
		{
			var mockProdRepo = new Mock<IProductRepository>();
			var objProdect = new Product("testCat","testName", "testDesc",0);
			mockProdRepo.Setup(p => p.Get(Guid.NewGuid())).Returns(objProdect);

			var result = mockProdRepo.Object.Get(objProdect.Id);
			Assert.AreEqual(objProdect, result);
		}
	}
}
