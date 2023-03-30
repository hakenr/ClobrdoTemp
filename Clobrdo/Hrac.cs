using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo
{
	public class Hrac
	{
		public string Jmeno { get; }

		public List<Figurka> Figurky { get; } = new();

		public Hrac(string jmeno)
		{
			this.Jmeno = jmeno;
		}

		public void PridejFigurku(Figurka figurka)
		{
			Figurky.Add(figurka);
		}
	}
}
