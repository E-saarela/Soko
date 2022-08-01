using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;                                    
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sökö_laskuri
{

    public partial class Form1 : Form
    {
        private PictureBox[] siirrettava = new PictureBox[1];
        private List<Kortti> pakka = new List<Kortti>();
        private List<Kortti> taysiPakka = new List<Kortti>();
        private List<Kortti> kasi = new List<Kortti>();
        private Kortti[] kas1 = new Kortti[5];
        private Boolean valittu = false;
        private Boolean samavalittu = false;
        private Boolean vaihto = false;
        private Maa[] maat = new Maa[] {Maa.Pata, Maa.Risti, Maa.Hertta, Maa.Ruutu};
        

        public Form1()
        {
            InitializeComponent();
            foreach (Maa maa in maat)
            { 
                for (int i = 1; i < 14; i++)
                {
                   pakka.Add(new Kortti((Arvo)i, (Maa)maa));
                }
            }
            taysiPakka = pakka;
        }

        private void kasi_klik(Object sender, MouseEventArgs e)
        {
            if (siirrettava.Length < 1) lisaaKortti(siirrettava[0].Name);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PictureBox uusi = (PictureBox)sender;
                valittu = false;
                if (uusi.Image == null || siirrettava[0].Image == null)
                {
                    if (samavalittu == true) lisaaCounter();
                    samavalittu = false;
                }
                Image tyhja = uusi.Image;
                uusi.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = uusi;
            }

        }

        private void kortti_klik(object sender, EventArgs e)
        {
            /// pitä erottaa korttien vaihto korttien "pelaamisesta"
            PictureBox klikattu = (PictureBox)sender;
            if (klikattu.Image == null)
            {
                Image tyhja = klikattu.Image;
                klikattu.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = klikattu;
                if (samavalittu == false) vahennaCounter();
                samavalittu = true;
            }
            else
            {
                if (klikattu.Image == null)
                    return;
                else
                {
                    siirrettava[0] = klikattu;
                }

                if (valittu == false)
                {
                    lisaaCounter();
                    valittu = true;
                    samavalittu = false;
                }
            }
        }

        private void resetButton_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void lisaaCounter()
        {
            string luku = kortit_counter.Text;
            int arvo = Int16.Parse(luku);
            arvo++;
            kortit_counter.Text = arvo.ToString();
        }

        private void vahennaCounter()
        {
            string luku = kortit_counter.Text;
            int arvo = Int16.Parse(luku);
            arvo--;
            kortit_counter.Text = arvo.ToString();
        }

        private void lisaaKortti(String nimi)
        {
            String[] jaettu = nimi.Split('_');
            Console.WriteLine(nimi);
            int arvo = Int16.Parse(jaettu[1]);
            String vertaus;
            foreach (Maa maa in Enum.GetValues(typeof(Maa)))
            {
                vertaus = maa.ToString();
                if (vertaus == jaettu[0])
                {
                    Kortti pelattu = new Kortti((Arvo)arvo, (Maa)maa);
                    for(int i = 0; i < 52; i++)
                    {
                                              
                        if (pakka.ElementAt(i).Maa == pelattu.Maa && pakka.ElementAt(i).Arvo == pelattu.Arvo)
                        {
                            pakka[i] = new Kortti();
                        }                           
                    }
                    kasi.Add(pelattu);
                    Kortti listaan = new Kortti((Arvo)arvo, (Maa)maa);
                    /// uusi laskutapa jäljellä oleville korteille
                }
                    
            }

        }

      

        private void fold(object sender, EventArgs e)
        {

            CheckBox s = (CheckBox)sender;
            string name = s.Name;

            switch (name)
            {
                case "cb1":
                    kasi1_2.Image = null;
                    kasi1_2.BackColor = Color.Red;
                    kasi1_3.Image = null;
                    kasi1_3.BackColor = Color.Red;
                    kasi1_4.Image = null;
                    kasi1_4.BackColor = Color.Red;
                    kasi1_5.Image = null;
                    kasi1_5.BackColor = Color.Red;
                    break;
                case "cb2":
                    kasi2_2.Image = null;
                    kasi2_2.BackColor = Color.Red;
                    kasi2_3.Image = null;
                    kasi2_3.BackColor = Color.Red;
                    kasi2_4.Image = null;
                    kasi2_4.BackColor = Color.Red;
                    kasi2_5.Image = null;
                    kasi2_5.BackColor = Color.Red;
                    break;
               case "cb3":
                    kasi3_2.Image = null;
                    kasi3_2.BackColor = Color.Red;
                    kasi3_3.Image = null;
                    kasi3_3.BackColor = Color.Red;
                    kasi3_4.Image = null;
                    kasi3_4.BackColor = Color.Red;
                    kasi3_5.Image = null;
                    kasi3_5.BackColor = Color.Red;
                    break;
                case "cb4":
                    kasi4_2.Image = null;
                    kasi4_2.BackColor = Color.Red;
                    kasi4_3.Image = null;
                    kasi4_3.BackColor = Color.Red;
                    kasi4_4.Image = null;
                    kasi4_4.BackColor = Color.Red;
                    kasi4_5.Image = null;
                    kasi4_5.BackColor = Color.Red;
                    break;
                case "cb5":
                    kasi5_2.Image = null;
                    kasi5_2.BackColor = Color.Red;
                    kasi5_3.Image = null;
                    kasi5_3.BackColor = Color.Red;
                    kasi5_4.Image = null;
                    kasi5_4.BackColor = Color.Red;
                    kasi5_5.Image = null;
                    kasi5_5.BackColor = Color.Red;
                    break;
                case "cb6":
                    kasi6_2.Image = null;
                    kasi6_2.BackColor = Color.Red;
                    kasi6_3.Image = null;
                    kasi6_3.BackColor = Color.Red;
                    kasi6_4.Image = null;
                    kasi6_4.BackColor = Color.Red;
                    kasi6_5.Image = null;
                    kasi6_5.BackColor = Color.Red;
                    break;
            }



            
            
        }
    }
}
