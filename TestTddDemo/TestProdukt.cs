using System;
using System.Collections.Generic;
using System.Text;
using TddDemo;
using Xunit;

namespace TestTddDemo
{
	public class TestProdukt
	{
		// [Theory] can run several different values
		[Fact]
		public void PrisExklusiveMoms_SkaReturneraPrisetDirekt()
		{
			// arrange
			double expected = 999.5;
			Produkt produkt = new Produkt("dator", expected);

			// act
			double actual = produkt.PrisExklusiveMoms();

			// assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void PrisInklusiveMoms_SkaReturneraPrisetPlusMoms()
		{
			// arrange
			double price = 225;
			double expected = price * 1.25;
			Produkt produkt = new Produkt("wrench", price);

			// act
			double actual = produkt.PrisInklusiveMoms();

			// assert
			Assert.Equal(expected, actual);
		}
	}
}
