using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo
{
	public class Hra
	{
		List<Hrac> hraci = new();
		HraciDeska hraciDeska;

		public void PridejHrace(Hrac hrac)
		{
			if (hraci.Count < hraciDeska.MaximalniPocetHracu)
			{
				for (int i = 0; i < 1; i++)
				{
					Figurka figurka = new Figurka($"{hrac.Jmeno[0]}{i + 1}");
					hrac.PridejFigurku(figurka);
					hraciDeska.PolozFigurkuNaStart(figurka);
				}
				hraci.Add(hrac);
			}
			else
			{
				throw new Exception($"Hráč {hrac.Jmeno} nelze přidat, hrací deska je plna");
			}
		}

		public Hra(HraciDeska hraciDeska)
		{
			this.hraciDeska = hraciDeska;
		}

		public void Start()
		{
			var kostka = new Kostka(6);
			hraciDeska.Vypis();

			while (true)
			{
				if (JeDohrano())
				{
					Console.WriteLine("Máme vítěze, hra skončila.");
					break;
				}
				
				foreach (var hrac in hraci)
				{
					Console.WriteLine($"Hraje hráč {hrac.Jmeno}");
					int hod = kostka.Hod();

					// TODO - Herní strategie - výběr figurky
					Figurka figurka = hrac.Figurky.First();
					hraciDeska.PosunFigurku(figurka, hod);

					hraciDeska.Vypis();
				}
			}

			Console.WriteLine("Konec všeho.");
		}

		private bool JeDohrano()
		{
			foreach (var hrac in hraci)
			{
				if (hrac.Figurky.All(figurka => hraciDeska.JeFigurkaVDomecku(figurka)))
				{
					return true;
				}
			}
			return false;
		}
	}
}
