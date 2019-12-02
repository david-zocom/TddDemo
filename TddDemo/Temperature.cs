using System;
using System.Collections.Generic;
using System.Text;

namespace TddDemo
{
	public class Temperature
	{
		public static double absoluteZero = -273.15;
		public double CelsiusToFahrenheit(double degrees)
		{
			if (degrees < absoluteZero)
				throw new Exception("Too cold! brrr");
			else if (degrees > double.MaxValue)
				throw new Exception("Too hot!");
			else
			{
				return degrees * 1.8 + 32;
			}
		}
	}
}
