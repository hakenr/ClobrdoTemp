using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo
{
	public class Kostka
	{
		int pocetSten;

		public Kostka(int pocetSten)
		{
			this.pocetSten = pocetSten;
		}

		public int Hod()
		{
			return Random.Shared.Next(1, pocetSten);
		}
	}
}
