using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Controls;
using AForge;
using AForge.Math;
using AForge.Math.Geometry;

namespace Projektinz
{
    public partial class Form2 : Form
    {
        private Form1 rodzic;
        public System.Drawing.Image wyb;

        public Form2(Form1 rodzic)
        {
            InitializeComponent();
            this.rodzic = rodzic;
        }
        public void Uzupelnienie(System.Drawing.Image wyb)
        {

                pictureBox1.Image = (Bitmap)wyb;
                Obraz o = new Obraz();
                o.Metody(wyb);
                pictureBox2.Image =o.piaty;

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            rodzic.Show();
        }
    }
}
