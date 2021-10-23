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


        private void kasi_klik(Object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PictureBox uusi = (PictureBox)sender;
                Image tyhja = uusi.Image;
                uusi.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = uusi;
            }
        }
 
        private void kortti_klik(object sender, EventArgs e)
        {
            PictureBox kortti = (PictureBox)sender;
            if (kortti.Image == null)
                return;
            else
            {
                siirrettava[0] = kortti;
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
