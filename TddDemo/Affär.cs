using System;
using System.Collections.Generic;
using System.Text;

namespace TddDemo
{
	/*
	 2 Skapa en klass med namnet Affär. Den ska ha en lista med produkter - objekt av klassen Produkt, se förra uppgiften. Klassen Affär ska ha en egenskap som är en lista med produkter: List<Produkt>.
2a Skriv en metod med namnet FinnsILager(string). Den ska returnera true om en produkt med ett visst namn finns i affärens lista med produkter, och false annars. Skriv testfall som testar funktionen när
- produkten finns
- produkten inte finns (men det finns andra produkter)
- affären är tom (slutsålt/nyöppnad)

		 */
	public class Affär
	{
		// null is default value for objects
		public List<Produkt> produkter = new List<Produkt>();

		public bool FinnsILager(string namn)
		{
			foreach (var produkt in produkter)
			{
				if (produkt.namn == namn)
					return true;
			}
			return false;
		}
		
	}
}
