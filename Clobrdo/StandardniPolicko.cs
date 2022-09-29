using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo
{
	public class StandardniPolicko : Policko
	{
		Figurka figurka;

		public override void PolozFigurku(Figurka figurka)
		{
			if (JeObsazeno())
			{
				throw new InvalidOperationException("Policko je obsazeno");
			}

			this.figurka = figurka;
		}

		public override bool JeObsazeno()
		{
			return (this.figurka != null); // (this.Figurka is not null)  (this.Figurka is Figurka)
		}

	}
}
