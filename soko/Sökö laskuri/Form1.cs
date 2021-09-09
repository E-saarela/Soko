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
        PictureBox[] siirrettava = new PictureBox[1];
        PictureBox[] kortit = new PictureBox[52];
        PictureBox[] muutetut = new PictureBox[52];
        int pelatut = 0;
        public Form1()
        {
            InitializeComponent();
            kortit[0] = pata2;
            kortit[1] = pata3;
            kortit[2] = pata4;
            kortit[3] = pata5;
            kortit[4] = pata6;
            kortit[5] = pata7;
            kortit[6] = pata8;
            kortit[7] = pata9;
            kortit[8] = pata10;
            kortit[9] = pataJ;
            kortit[10] = pataQ;
            kortit[11] = pataK;
            kortit[12] = pataA;
            kortit[13] = risti2;
            kortit[14] = risti3;
            kortit[15] = risti4;
            kortit[16] = risti5;
            kortit[17] = risti6;
            kortit[18] = risti7;
            kortit[19] = risti8;
            kortit[20] = risti9;
            kortit[21] = risti10;
            kortit[22] = ristiJ;
            kortit[23] = ristiQ;
            kortit[24] = ristiK;
            kortit[25] = ristiA;
            kortit[26] = hertta2;
            kortit[27] = hertta3;
            kortit[28] = hertta4;
            kortit[29] = hertta5;
            kortit[30] = hertta6;
            kortit[31] = hertta7;
            kortit[32] = hertta8;
            kortit[33] = hertta9;
            kortit[34] = hertta10;
            kortit[35] = herttaJ;
            kortit[36] = herttaQ;
            kortit[37] = herttaK;
            kortit[38] = herttaA;
            kortit[39] = ruutu2;
            kortit[40] = ruutu3;
            kortit[41] = ruutu4;
            kortit[42] = ruutu5;
            kortit[43] = ruutu6;
            kortit[44] = ruutu7;
            kortit[45] = ruutu8;
            kortit[46] = ruutu9;
            kortit[47] = ruutu10;
            kortit[48] = ruutuJ;
            kortit[49] = ruutuQ;
            kortit[50] = ruutuK;
            kortit[51] = ruutuA;
            for(int i = 0; i < kortit.Length - 1; i++)
            {
                PictureBox uusi = new PictureBox();
                uusi.Location = kortit[i].Location;
                uusi.Size = kortit[i].Size;
                uusi.Image = kortit[i].Image;
                uusi.SizeMode = kortit[i].SizeMode;
                uusi.Visible = false;
                muutetut[i] = uusi;
            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

   


        /////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
        
        //kädet
         

        private void kasi_klik(Object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi1_2.Image;
                kasi1_2.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi1_2;
            }
        }

        private void kasi1_3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi1_3.Image;
                kasi1_3.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi1_3;
            }
        }

        private void kasi1_4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi1_4.Image;
                kasi1_4.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi1_4;
            }
        }

        private void kasi1_5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi1_5.Image;
                kasi1_5.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi1_5;
            }
        }

        private void kasi2_2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi2_2.Image;
                kasi2_2.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi2_2;
            }
        }

        private void kasi2_3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi2_3.Image;
                kasi2_3.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi2_3;
            }
        }

        private void kasi2_4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi2_4.Image;
                kasi2_4.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi2_4;
            }
        }

        private void kasi2_5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi2_5.Image;
                kasi2_5.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi2_5;
            }
        }

        private void kasi3_2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi3_2.Image;
                kasi3_2.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi3_2;
            }
        }

        private void kasi3_3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi3_3.Image;
                kasi3_3.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi3_3;
            }
        }

        private void kasi3_4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi3_4.Image;
                kasi3_4.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi3_4;
            }
        }

        private void kasi3_5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi3_5.Image;
                kasi3_5.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi3_5;
            }
        }

        private void kasi4_2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi4_2.Image;
                kasi4_2.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi4_2;
            }
        }

        private void kasi4_3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi4_3.Image;
                kasi4_3.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi4_3;
            }
        }

        private void kasi4_4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi4_4.Image;
                kasi4_4.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi4_4;
            }
        }

        private void kasi4_5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi4_5.Image;
                kasi4_5.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi4_5;
            }
        }

        private void kasi5_2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi5_2.Image;
                kasi5_2.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi5_2;
            }
        }

        private void kasi5_3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi5_3.Image;
                kasi5_3.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi5_3;
            }
        }

        private void kasi5_4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi5_4.Image;
                kasi5_4.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi5_4;
            }
        }

        private void kasi5_5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi5_5.Image;
                kasi5_5.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi5_5;
            }
        }

        private void kasi6_2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi6_2.Image;
                kasi6_2.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi6_2;
            }
        }

        private void kasi6_3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi6_3.Image;
                kasi6_3.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi6_3;
            }
        }

        private void kasi6_4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi6_4.Image;
                kasi6_4.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi6_4;
            }
        }

        private void kasi6_5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image tyhja = kasi6_5.Image;
                kasi6_5.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi6_5;
            }
        }



        //////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////
        ///kortit
        

        private void pata2_Click(object sender, EventArgs e)
        {
            if (pata2.Image == null)
                return;
            else
            {
                siirrettava[0] = pata2;
                pelatut++;
            }
        }

        private void pata3_Click(object sender, EventArgs e)
        {
            if (pata3.Image == null)
                return;
            else
            {
                siirrettava[0] = pata3;
                pelatut++;
            }
        }

        private void pata4_Click(object sender, EventArgs e)
        {
            if (pata4.Image == null)
                return;
            else
            {
                siirrettava[0] = pata4;
                pelatut++;
            }
        }

        private void pata5_Click(object sender, EventArgs e)
        {
            if (pata5.Image == null)
                return;
            else
            {
                siirrettava[0] = pata5;
                pelatut++;
            }
        }

        private void pata6_Click(object sender, EventArgs e)
        {
            if (pata6.Image == null)
                return;
            else
            {
                siirrettava[0] = pata6;
                pelatut++;
            }
        }

        private void pata7_Click(object sender, EventArgs e)
        {
            if (pata7.Image == null)
                return;
            else
            {
                siirrettava[0] = pata7;
                pelatut++;
            }
        }

        private void pata8_Click(object sender, EventArgs e)
        {
            if (pata8.Image == null)
                return;
            else
            {
                siirrettava[0] = pata8;
                pelatut++;
            }
        }

        private void pata9_Click(object sender, EventArgs e)
        {
            if (pata9.Image == null)
                return;
            else
            {
                siirrettava[0] = pata9;
                pelatut++;
            }
        }

        private void pata10_Click(object sender, EventArgs e)
        {
            if (pata10.Image == null)
                return;
            else
            {
                siirrettava[0] = pata10;
                pelatut++;
            }
        }

        private void pataJ_Click(object sender, EventArgs e)
        {
            if (pataJ.Image == null)
                return;
            else
            {
                siirrettava[0] = pataJ;
                pelatut++;
            }
        }

        private void pataQ_Click(object sender, EventArgs e)
        {
            if (pataQ.Image == null)
                return;
            else
            {
                siirrettava[0] = pataQ;
                pelatut++;
            }
        }

        private void pataK_Click(object sender, EventArgs e)
        {
            if (pataK.Image == null)
                return;
            else
            {
                siirrettava[0] = pataK;
                pelatut++;
            }
        }

        private void pataA_Click(object sender, EventArgs e)
        {
            if (pataA.Image == null)
                return;
            else
            {
                siirrettava[0] = pataA;
                pelatut++;
            }
        }

        private void risti2_Click(object sender, EventArgs e)
        {
            if (risti2.Image == null)
                return;
            else
            {
                siirrettava[0] = risti2;
                pelatut++;
            }
        }

        private void risti3_Click(object sender, EventArgs e)
        {
            if (risti3.Image == null)
                return;
            else
            {
                siirrettava[0] = risti3;
                pelatut++;
            }
        }

        private void risti4_Click(object sender, EventArgs e)
        {
            if (risti4.Image == null)
                return;
            else
            {
                siirrettava[0] = risti4;
                pelatut++;
            }
        }

        private void risti5_Click(object sender, EventArgs e)
        {
            if (risti5.Image == null)
                return;
            else
            {
                siirrettava[0] = risti5;
                pelatut++;
            }
        }

        private void risti6_Click(object sender, EventArgs e)
        {
            if (risti6.Image == null)
                return;
            else
            {
                siirrettava[0] = risti6;
                pelatut++;
            }
        }

        private void risti7_Click(object sender, EventArgs e)
        {
            if (risti7.Image == null)
                return;
            else
            {
                siirrettava[0] = risti7;
                pelatut++;
            }
        }

        private void risti8_Click(object sender, EventArgs e)
        {
            if (risti8.Image == null)
                return;
            else
            {
                siirrettava[0] = risti8;
                pelatut++;
            }
        }

        private void risti9_Click(object sender, EventArgs e)
        {
            if (risti9.Image == null)
                return;
            else
            {
                siirrettava[0] = risti9;
                pelatut++;
            }
        }

        private void risti10_Click(object sender, EventArgs e)
        {
            if (risti10.Image == null)
                return;
            else
            {
                siirrettava[0] = risti10;
                pelatut++;
            }
        }

        private void ristiJ_Click(object sender, EventArgs e)
        {
            if (ristiJ.Image == null)
                return;
            else
            {
                siirrettava[0] = ristiJ;
                pelatut++;
            }
        }

        private void ristiQ_Click(object sender, EventArgs e)
        {
            if (ristiQ.Image == null)
                return;
            else
            {
                siirrettava[0] = ristiQ;
                pelatut++;
            }
        }

        private void ristiK_Click(object sender, EventArgs e)
        {
            if (ristiK.Image == null)
                return;
            else
            {
                siirrettava[0] = ristiK;
                pelatut++;
            }
        }

        private void ristiA_Click(object sender, EventArgs e)
        {
            if (ristiA.Image == null)
                return;
            else
            {
                siirrettava[0] = ristiA;
                pelatut++;
            }
        }

        private void hertta2_Click(object sender, EventArgs e)
        {
            if (hertta2.Image == null)
                return;
            else
            {
                siirrettava[0] = hertta2;
                pelatut++;
            }
        }

        private void hertta3_Click(object sender, EventArgs e)
        {
            if (hertta3.Image == null)
                return;
            else
            {
                siirrettava[0] = hertta3;
                pelatut++;
            }
        }

        private void hertta4_Click(object sender, EventArgs e)
        {
            if (hertta4.Image == null)
                return;
            else
            {
                siirrettava[0] = hertta4;
                pelatut++;
            }
        }

        private void hertta5_Click(object sender, EventArgs e)
        {
            if (hertta5.Image == null)
                return;
            else
            {
                siirrettava[0] = hertta5;
                pelatut++;
            }
        }

        private void hertta6_Click(object sender, EventArgs e)
        {
            if (hertta6.Image == null)
                return;
            else
            {
                siirrettava[0] = hertta6;
                pelatut++;
            }
        }

        private void hertta7_Click(object sender, EventArgs e)
        {
            if (hertta7.Image == null)
                return;
            else
            {
                siirrettava[0] = hertta7;
                pelatut++;
            }
        }

        private void hertta8_Click(object sender, EventArgs e)
        {
            if (hertta8.Image == null)
                return;
            else
            {
                siirrettava[0] = hertta8;
                pelatut++;
            }
        }

        private void hertta9_Click(object sender, EventArgs e)
        {
            if (hertta9.Image == null)
                return;
            else
            {
                siirrettava[0] = hertta9;
                pelatut++;
            }
        }

        private void hertta10_Click(object sender, EventArgs e)
        {
            if (hertta10.Image == null)
                return;
            else
            {
                siirrettava[0] = hertta10;
                pelatut++;
            }
        }

        private void herttaJ_Click(object sender, EventArgs e)
        {
            if (herttaJ.Image == null)
                return;
            else
            {
                siirrettava[0] = herttaJ;
                pelatut++;
            }
        }

        private void herttaQ_Click(object sender, EventArgs e)
        {
            if (herttaQ.Image == null)
                return;
            else
            {
                siirrettava[0] = herttaQ;
                pelatut++;
            }
        }

        private void herttaK_Click(object sender, EventArgs e)
        {
            if (herttaK.Image == null)
                return;
            else
            {
                siirrettava[0] = herttaK;
                pelatut++;
            }
        }

        private void herttaA_Click(object sender, EventArgs e)
        {
            if (herttaA.Image == null)
                return;
            else
            {
                siirrettava[0] = herttaA;
                pelatut++;
            }
        }

        private void ruutu2_Click(object sender, EventArgs e)
        {
            if (ruutu2.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutu2;
                pelatut++;
            }
        }

        private void ruutu3_Click(object sender, EventArgs e)
        {
            if (ruutu3.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutu3;
                pelatut++;
            }
        }

        private void ruutu4_Click(object sender, EventArgs e)
        {
            if (ruutu4.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutu4;
                pelatut++;
            }
        }

        private void ruutu5_Click(object sender, EventArgs e)
        {
            if (ruutu5.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutu5;
                pelatut++;
            }
        }

        private void ruutu6_Click(object sender, EventArgs e)
        {
            if (ruutu6.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutu6;
                pelatut++;
            }
        }

        private void ruutu7_Click(object sender, EventArgs e)
        {
            if (ruutu7.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutu7;
                pelatut++;
            }
        }

        private void ruutu8_Click(object sender, EventArgs e)
        {
            if (ruutu8.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutu8;
                pelatut++;
            }
        }

        private void ruutu9_Click(object sender, EventArgs e)
        {
            if (ruutu9.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutu9;
                pelatut++;
            }
        }

        private void ruutu10_Click(object sender, EventArgs e)
        {
            if (ruutu10.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutu10;
                pelatut++;
            }
        }

        private void ruutuJ_Click(object sender, EventArgs e)
        {
            if (ruutuJ.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutuJ;
                pelatut++;
            }
        }

        private void ruutuQ_Click(object sender, EventArgs e)
        {
            if (ruutuQ.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutuQ;
                pelatut++;
            }
        }

        private void ruutuK_Click(object sender, EventArgs e)
        {
            if (ruutuK.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutuK;
                pelatut++;
            }
        }

        private void ruutuA_Click(object sender, EventArgs e)
        {
            if (ruutuA.Image == null)
                return;
            else
            {
                siirrettava[0] = ruutuA;
                pelatut++;
            }
        }

        private void resetButton_MouseClick(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < kortit.Length; i++)
            {
                PictureBox uusi = new PictureBox();
                
                kortit[i] = muutetut[i];
            }
            
        }
    }
}
