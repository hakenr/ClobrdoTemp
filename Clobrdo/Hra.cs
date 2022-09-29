using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo
{
	public class Hra
	{
		public int Score { get; set; }

		List<Hrac> hraci = new();
		HraciDeska hraciDeska;

		public void PridejHrace(Hrac hrac)
		{
			if (hraci.Count < hraciDeska.MaximalniPocetHracu)
			{
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
	}
}
