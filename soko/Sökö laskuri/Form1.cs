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
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void pata3_MouseClick(Object sender, MouseEventArgs e)
        { 
            if (e.Button == System.Windows.Forms.MouseButtons.Left) 
            {
                siirrettava[0] = pata3;
            }
        }

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
                Image tyhja = kasi1_2.Image;
                kasi1_2.Image = siirrettava[0].Image;
                siirrettava[0].Image = tyhja;
                Array.Clear(siirrettava, 0, siirrettava.Length);
                siirrettava[0] = kasi1_2;
            }
        }

        private void kasi1_4_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi1_5_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi2_2_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi2_3_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi2_4_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi2_5_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi3_2_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi3_3_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi3_4_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi3_5_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi4_2_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi4_3_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi4_4_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi4_5_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi5_2_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi5_3_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi5_4_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi5_5_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi6_2_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi6_3_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi6_4_MouseClick(object sender, MouseEventArgs e)
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

        private void kasi6_5_MouseClick(object sender, MouseEventArgs e)
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
    }
}
