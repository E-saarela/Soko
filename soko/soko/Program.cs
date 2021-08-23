using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// @author(s) E-Saarela
/// @0.05 23.8.2021
/// <summary>
/// Laskee sökön kortteja
/// </summary>
///
namespace soko
{
	class Program
	{

		public static void Main(string[] args)
		{
			var rand = new Random();
			var kasi = new List<Kortti>();

			while (!Console.KeyAvailable)
			{
				//Luo sattumanvaraisen käden
				kasi.Clear();
				var korttienMaara = 5; //5 Korttia
				for (int i = 0; i < korttienMaara; i++)
					kasi.Add(new Kortti((Arvo)rand.Next(13) + 1, (Maa)rand.Next(4)));

				//Testataan tulostus
				Console.WriteLine("Sinun korttisi:");
				foreach (Kortti c in kasi)
				{
					Console.WriteLine("\t" + c.ToString());
					System.Threading.Thread.Sleep(1000);
				}
				var kortitTaulukkoon = kasi.ToArray();
				TunnistaKasi tunnistus = new TunnistaKasi();
				SokoKasi kadentulos = tunnistus.Tunnista(kortitTaulukkoon);
				Console.WriteLine(kadentulos.ToString());
				System.Threading.Thread.Sleep(5000);
			}
		}

	}
}
