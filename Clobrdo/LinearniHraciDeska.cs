﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo
{
	public class LinearniHraciDeska : HraciDeska
	{
		public override int MaximalniPocetHracu
		{
			get
			{
				return int.MaxValue;
			}
		}

		List<Policko> policka = new();

		public LinearniHraciDeska(int pocetPolicek)
		{
			policka.Add(new StartovniPolicko());
			
			for (int i = 0; i < pocetPolicek - 2; i++)
			{
				var policko = new StandardniPolicko();
				policka.Add(policko);
			}

			var domecek = new Domecek();
			policka.Add(domecek);
		}

		public override void PolozFigurkuNaStart(Figurka figurka)
		{
			if (policka[0] is not StartovniPolicko)
			{
				throw new InvalidOperationException("Něco je špatně, první políčko není startovní.");
			}
			policka[0].PolozFigurku(figurka);
		}

		public override bool JeFigurkaVDomecku(Figurka figurka)
		{
			var domecek = policka.Last();
			if (domecek is not Domecek)
			{
				throw new InvalidOperationException("Něco je špatně, poslední políčko není domeček.");
			}
			return domecek.JeTamFigurka(figurka);
		}

		public override bool PosunFigurku(Figurka figurka, int pocetPolicek)
		{
			var pocatecniPolicko = DejPolicko(figurka);

			var indexPocatecnihoPolicka = policka.IndexOf(pocatecniPolicko);
			var indexCile = indexPocatecnihoPolicka + pocetPolicek;

			if (indexCile > policka.Count - 1)
			{
				Console.WriteLine("Figurka musí trefit domeček přesně, zůstává na místě.");
				return false;
			}

			var cilovePolicko = policka[indexCile];
			
			// vyhazování
			var vyhozenaFigurka = cilovePolicko.DejFigurkuKVyhozeni();
			if (vyhozenaFigurka != null)
			{
				cilovePolicko.ZvedniFigurku(vyhozenaFigurka);
				
				var startovniPolicko = policka.First();
				startovniPolicko.PolozFigurku(vyhozenaFigurka);
			}

			pocatecniPolicko.ZvedniFigurku(figurka);
			cilovePolicko.PolozFigurku(figurka);

			return true;
		}

		private Policko? DejPolicko(Figurka figurka)
		{
			return policka.FirstOrDefault(policko => policko.JeTamFigurka(figurka));
		}

		public override void Vypis()
		{
			foreach (var policko in policka)
			{
				policko.Vypis();	
			}
			Console.WriteLine();
		}
	}
}
