using System;
using System.Collections.Generic;
using System.Text;

namespace TddDemo
{
	public class Shop
	{
		public List<Produkt> products;
		private IDataSource dataSource;

		public Shop(IDataSource dataSource)
		{
			this.dataSource = dataSource;
		}
		public void GetProductsFromSource()
		{
			products = dataSource.GetProducts();
		}
	}
}
