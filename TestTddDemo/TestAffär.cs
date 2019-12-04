using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TddDemo;

namespace TestTddDemo
{
	public class TestAffär
	{
		//		Skriv testfall som testar funktionen när
		//- produkten finns
		//- produkten inte finns(men det finns andra produkter)
		//- affären är tom(slutsålt/nyöppnad)
		[Fact]
		public void FinnsILager_ReturneraTrueOmProduktenFinns()
		{
			// arrange
			Affär affär = new Affär();
			string produktNamn = "tandborste";
			Produkt tandborste = new Produkt(produktNamn, 22);
			affär.produkter.Add(tandborste);

			// act
			bool lagerStatus = affär.FinnsILager(produktNamn);

			// assert
			Assert.True(lagerStatus);
		}

		[Fact]
		public void FinnsILager_ReturneraFalseOmProduktenInteFinns()
		{
			// arrange
			Affär affär = new Affär();
			string produktNamn = "tandborste";
			Produkt tandborste = new Produkt(produktNamn, 22);
			affär.produkter.Add(tandborste);

			// act
			bool lagerStatus = affär.FinnsILager("hårspray");

			// assert
			Assert.False(lagerStatus);
		}

		[Fact]
		public void FinnsILager_ReturneraFalseOmAffärenÄrTom()
		{
			// arrange
			Affär affär = new Affär();

			// act
			bool lagerStatus = affär.FinnsILager("tandborste");

			// assert
			Assert.False(lagerStatus);
		}
	}
}
