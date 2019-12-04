using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TddDemo;
using Moq;

namespace TestTddDemo
{
	public class TestShop
	{
		[Fact]
		public void GetProductsFromSource_ActuallyFetchesProducts()
		{
			// arrange
			List<Produkt> testProducts = new List<Produkt>()
			{
				new Produkt("banan", 10)
			};
			var mockDataSource = new Mock<IDataSource>();
			mockDataSource.Setup(obj => obj.GetProducts()).Returns(testProducts);
			Shop shop = new Shop(mockDataSource.Object);

			// act
			shop.GetProductsFromSource();

			// assert
			Assert.Equal(testProducts, shop.products);
		}
	}
}
