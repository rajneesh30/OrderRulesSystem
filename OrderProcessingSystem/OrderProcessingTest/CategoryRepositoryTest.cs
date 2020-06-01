using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Order.Domain.Model;
using OrderProcessingSystem.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingTest
{
    class CategoryRepositoryTest
    {
		[TestMethod]
		public void GetById_Returns_Category()
		{
			var mockProdRepo = new Mock<ICategoryRepository>();
			var objCategory = new Category("testName", "testDesc");
			mockProdRepo.Setup(p => p.Get(Guid.NewGuid())).Returns(objCategory);

			var result = mockProdRepo.Object.Get(objCategory.Id);
			Assert.AreEqual(objCategory, result);
		}
	}
}
