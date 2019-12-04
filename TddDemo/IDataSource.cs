using System;
using System.Collections.Generic;
using System.Text;

namespace TddDemo
{
	public interface IDataSource
	{
		List<Produkt> GetProducts();
	}
}
