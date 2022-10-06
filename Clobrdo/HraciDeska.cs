namespace Clobrdo
{
	public abstract class HraciDeska
	{
		public abstract int MaximalniPocetHracu { get; }

		public abstract void PolozFigurkuNaStart(Figurka figurka);

		public abstract bool JeFigurkaVDomecku(Figurka figurka);

		public abstract bool PosunFigurku(Figurka figurka, int pocetPolicek);

		public abstract void Vypis();
	}
}
												