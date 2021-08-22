using System;
using System.Collections.Generic;
using System.Text;

namespace soko
{
	public enum Arvo
	{
		Assa = 1,
		Kakkonen,
		Kolmonen,
		Nelonen,
		Vitonen,
		Kutonen,
		Seiska,
		Kasi,
		Ysi,
		Kymppi,
		Jatka,
		Kuningatar,
		Kuningas
	}

	public enum Maa
	{
		Pata,
		Risti,
		Hertta,
		Ruutu
	}


	struct Kortti
	{
		public Arvo Arvo { get; private set; }
		public Maa Maa { get; private set; }
		public bool IsKnown { get; set; }

		public Kortti(Arvo a, Maa m) : this()
		{
			Arvo = a;
			Maa = m;
			IsKnown = true;
		}

		public override string ToString()
		{
			return Maa.ToString() + " " + Arvo.ToString();
		}
	}
}
