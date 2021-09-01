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
        PictureBox siirrettava;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void pata3_MouseClick(PictureBox sender, MouseEventArgs e)
        { 
            if (e.Button == System.Windows.Forms.MouseButtons.Left) 
            {
                siirrettava = sender;
            }
        }

        private void kasi_klik(object sender, MouseEventArgs e)
        {
           // sender. = siirrettava.Image;                 /// pitäs tonne parametrina jotenkin ton pictureboxin tiedot
            siirrettava.Image.Dispose();
            Console.WriteLine(sender.ToString());
        }


    }
}
