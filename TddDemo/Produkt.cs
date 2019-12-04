using System;
using System.Collections.Generic;
using System.Text;

namespace TddDemo
{
	/*
	 1 Skapa en klass som beskriver något man kan sälja i en affär. Den ska ha namnet Produkt och egenskaperna namn och prisExMoms (double). Skapa metoderna PrisExklusiveMoms och PrisInklusiveMoms. Den första ska returnera priset direkt, den andra ska returnera priset inklusive moms. Om något kostar 100 kr utan moms så kostart det 25% mer med moms, dvs 125 kr.
	Skriv testfall som testar att funktionerna returnerar rätt värde. Ett testfall per funktion.

		 */
	public class Produkt
	{
		public string namn;
		private double prisExMoms;
		public Produkt(string namn, double prisExMoms)
		{
			this.namn = namn;
			this.prisExMoms = prisExMoms;
		}

		public double PrisInklusiveMoms()
		{
			return this.prisExMoms * 1.25;
		}

		public double PrisExklusiveMoms()
		{
			return prisExMoms;
		}
	}
}
