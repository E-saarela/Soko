using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using static soko.TunnistaKasi;
using soko;

namespace Testsoko
{
	[TestFixture]
	public  class TestTunnistaKasi
	{
		[Test]
		public  void TestOnkoNeliVari112()
		{
			var kasi = new List<Kortti>();
			var rand = new Random();
			kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Pata) ));
			kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Pata) ));
			kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Pata) ));
			kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Pata) ));
			kasi.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Hertta) ));
			var kortitTaulukkoon = kasi.ToArray();
			TunnistaKasi tunnistus = new TunnistaKasi();
			Assert.AreEqual( true, tunnistus.OnkoNeliVari(kortitTaulukkoon) , "in method OnkoNeliVari, line 122");
			var kasi2 = new List<Kortti>();
			var rand2 = new Random();
			kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Risti) ));
			kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Risti) ));
			kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Risti) ));
			kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Risti) ));
			kasi2.Add(new Kortti((Arvo) rand.Next(13) + 1, (Maa.Hertta) ));
			var kortitTaulukkoon2 = kasi2.ToArray();
			TunnistaKasi tunnistus2 = new TunnistaKasi();
			Assert.AreEqual( true, tunnistus2.OnkoNeliVari(kortitTaulukkoon2) , "in method OnkoNeliVari, line 132");
		}
	}
}

