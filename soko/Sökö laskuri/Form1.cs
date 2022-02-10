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
        private PictureBox[] kortit = new PictureBox[52];
        private PictureBox[] muutetut = new PictureBox[52];
        private List<Kortti> kasi = new List<Kortti>();
        private Kortti[] kas1 = new Kortti[5];
        private Boolean valittu = false;
        private Boolean samavalittu = false;
        private Boolean vaihto = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void kasi_klik(Object sender, MouseEventArgs e)
        {

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
                    kasi.Add(new Kortti((Arvo)arvo, (Maa)maa));
                    Kortti listaan = new Kortti((Arvo)arvo, (Maa)maa);
                    
                }
                    
            }

        }

        private void kasi1_kasittele(object sender, EventArgs e)
        {
            lisaaKortti(siirrettava[0].Name);
        }
    }
}
