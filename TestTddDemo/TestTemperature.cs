using System;
using Xunit;
using TddDemo;

namespace TestTddDemo
{
	public class TestTemperature
	{
		[Fact]
		public void ThrowsWhenTooCold()
		{
			// arrange
			Temperature temp = new Temperature();

			// act, assert
			try
			{
				double neverUsed = temp.CelsiusToFahrenheit(-273.16);
			}
			catch (Exception)
			{
				Assert.True(true);
				return;
			}
			Assert.True(false);
		}

		[Fact]
		public void ThrowsWhenTooHot()
		{
			Temperature temp = new Temperature();
			try
			{
				double neverUsed = temp.CelsiusToFahrenheit(double.PositiveInfinity);
			}
			catch (Exception)
			{
				Assert.True(true);
				return;
			}
			Assert.True(false);
		}

		[Fact]
		public void ReturnsCorrectTemperature()
		{
			// arrange
			Temperature temp = new Temperature();
			double celsius = 101;
			double expected = 213.8;

			// act
			double actual = temp.CelsiusToFahrenheit(celsius);

			// assert
			Assert.Equal(expected, actual);
		}
	}
}
