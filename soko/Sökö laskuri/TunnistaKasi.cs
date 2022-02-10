using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sökö_laskuri
{
	public enum SokoKasi
	{
		Suurin,
		Pari,
		NeljanKortinSuora,
		NeljanKortinVari,
		KaksiParia,
		Kolmoset,
		Suora,
		Vari,
		TaysiKasi,
		Neloset,
		VariSuora
	}

	internal class TunnistaKasi
    {
		//Tallentaa jokaisen kortin lukumäärän kyseisessä kädessä
		//ässä on 0 ja kuningas 12
		private int[] KorttienArvojenMaara = new int[13];
		private SokoKasi TunnistaViisiKorttia(Kortti[] Kasi)
		{
			SokoKasi tulos = SokoKasi.Suurin;
			paivitaKorttienArvojenMaara(Kasi);

			int Parit = LaskeParit();
			if (Parit > 0)
			{
				tulos = Parit == 1 ? SokoKasi.Pari : SokoKasi.KaksiParia;
				bool onkoNeliVari = OnkoNeliVari(Kasi);
				if (onkoNeliVari == true)
					tulos = SokoKasi.NeljanKortinVari;
				bool onkoNeliSuora = OnkoNeliSuora();
				if (onkoNeliSuora == true)
					tulos = SokoKasi.NeljanKortinSuora;
				int suurin = SuurimmatSamat();
				if (suurin == 3)
					tulos = Parit == 2 ? SokoKasi.TaysiKasi : SokoKasi.Kolmoset; //Kolmoset lasketaan tässä keississä "pariksi"
				else if (suurin == 4)
					tulos = SokoKasi.Neloset;
			}
			else
			{
				bool onkoVari = OnkoVari(Kasi);
				bool onkoSuora = OnkoSuora();

				if (onkoVari && onkoSuora)
					tulos = SokoKasi.VariSuora;

				else if (onkoVari)
					tulos = SokoKasi.Vari;
				else if (onkoSuora)
					tulos = SokoKasi.Suora;
			}

			return tulos;
		}


		private void paivitaKorttienArvojenMaara(Kortti[] Kasi)
		{
			//alusta
			for (int i = 0; i < KorttienArvojenMaara.Length; i++)
				KorttienArvojenMaara[i] = 0;
			//päivitä
			foreach (Kortti Kortti in Kasi)
			{
				if (Kortti.IsKnown)
					KorttienArvojenMaara[(int)Kortti.Arvo - 1]++;
			}
		}


		/// <summary>
		/// Julkinen rajapinta käden arvioinnille
		/// </summary>
		public SokoKasi Tunnista(Kortti[] kasi)
		{
			if (kasi.Length == 5)
				return TunnistaViisiKorttia(kasi);
			throw new ArgumentException("Kädessä on oltava viisi korttia!");
		}


		private int SuurimmatSamat()
		{
			int max = 0;
			foreach (int i in KorttienArvojenMaara)
				if (i > max) max = i;
			return max;
		}

		private int LaskeParit()
		{
			int count = 0;
			foreach (int i in KorttienArvojenMaara)
				if (i >= 2) count++;
			return count;
		}



		/// <example>
		/// <pre name="test">
		/// var kasi = new List<Kortti>();
		/// var rand = new Random();
		/// kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Pata) ));
		/// kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Pata) ));
		/// kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Pata) ));
		/// kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Pata) ));
		/// kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Hertta) ));
		/// var kortitTaulukkoon = kasi.ToArray();
		/// TunnistaKasi tunnistus = new TunnistaKasi();
		/// tunnistus.OnkoNeliVari(kortitTaulukkoon) === true;
		/// var kasi2 = new List<Kortti>();
		/// var rand2 = new Random();
		/// kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Risti) ));
		/// kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Risti) ));
		/// kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Risti) ));
		/// kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Risti) ));
		/// kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Hertta) ));
		/// var kortitTaulukkoon2 = kasi2.ToArray();
		/// TunnistaKasi tunnistus2 = new TunnistaKasi();
		/// tunnistus2.OnkoNeliVari(kortitTaulukkoon2) === true;
		/// </pre>
		/// </example>
		public bool OnkoNeliVari(Kortti[] kasi)
		{
			int[] maanMaara = { 0, 0, 0, 0 }; //padat, ristit, hertat, ruudut (tässä järjestyksessä)
			foreach (Kortti kortti in kasi)
			{
				switch (kortti.Maa)
				{
					case Maa.Pata: maanMaara[0]++; break;
					case Maa.Risti: maanMaara[1]++; break;
					case Maa.Hertta: maanMaara[2]++; break;
					case Maa.Ruutu: maanMaara[3]++; break;
				}
			}

			foreach (int i in maanMaara)
				if (i == 4) return true;
			return false;
		}

		private bool OnkoVari(Kortti[] kasi)
		{
			int[] maanMaara = { 0, 0, 0, 0 }; //padat, ristit, hertat, ruudut (tässä järjestyksessä)
			foreach (Kortti kortti in kasi)
			{
				switch (kortti.Maa)
				{
					case Maa.Pata: maanMaara[0]++; break;
					case Maa.Risti: maanMaara[1]++; break;
					case Maa.Hertta: maanMaara[2]++; break;
					case Maa.Ruutu: maanMaara[3]++; break;
				}
			}

			foreach (int i in maanMaara)
				if (i == 5) return true;
			return false;
		}


		private bool OnkoNeliSuora()
		{
			int maara = 0;
			foreach (int i in KorttienArvojenMaara)
			{
				if (i == 1) maara++;
				else maara = 0;

				if (maara == 4) return true;
			}

			return maara == 3 && KorttienArvojenMaara[0] == 1; //ässä voi olla pienin tai suurin
		}

		private bool OnkoSuora()
		{
			int maara = 0;
			foreach (int i in KorttienArvojenMaara)
			{
				if (i == 1) maara++;
				else maara = 0;

				if (maara == 5) return true;
			}

			return maara == 4 && KorttienArvojenMaara[0] == 1; //ässä voi olla pienin tai suurin
		}
	}
}
