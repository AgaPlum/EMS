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
using System.Threading;

namespace Projektinz
{
    public partial class Form1 : Form
    {
        public int[][] TabdlaGr;//współrzędne dla rozgałęzień
        public int Czer;//ilość minucji zakończeń
        public int Ziel;//ilość minucji rozgałęzień
        public int Roz;//rozmiar dala wybranego odcisku
        public int Wysko;//wysokość odciska
        public int Szero;//szerokość odciska
        public int Centro;// wartość wybranych rozgałęzień połączenie i średnia
        public Bitmap[] wybrana = new Bitmap[2];
        public double[] inp;
        public System.Drawing.Image wybranyodcisk;// jako globalna by móc w odczycie dobrze wybrać i jest to wybrany przez użytkownika odcisk
        public Form1()
        {
            InitializeComponent();
            label1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image files (*.BMP, *.JPG, *.GIF)|*.bmp;*.jpg;*.gif";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    wybranyodcisk = System.Drawing.Image.FromFile(dlg.FileName);
                    pictureBox1.Image = wybranyodcisk;
                }
            }
            catch
            {
                MessageBox.Show("Błąd odczytu!");
            }
        }
        private void Przetwarzanie(System.Drawing.Image im)
        {
            progressBar1.PerformStep();
            Obraz ob = new Obraz();
            ob.Metody(im);
            Ziel = ob.Mgr;
            TabdlaGr = ob.TabGr;
            Czer = ob.Mred;
            Roz = ob.Rozmiar;
            Wysko = ob.wysokosc;
            Szero = ob.szerokosc;
            Centro = ob.cent;
            inp = new double[6] { Ziel, Czer, Wysko, Szero, Roz, Centro };
            progressBar1.PerformStep();
        }
        private void Neuronowe(System.Drawing.Image im)
        {
            progressBar1.PerformStep();
            Sieci s = new Sieci();
            wybrana = s.Obsluga(im, inp);
            double[] outp = s.output;
            pictureBox2.Image = (System.Drawing.Image)wybrana[0];
            pictureBox3.Image = (System.Drawing.Image)wybrana[1];
            label2.Text = outp[0].ToString();
            label3.Text = outp[1].ToString();
            int[] li = s.licz;
            label7.Text=li[0].ToString();
            label8.Text = li[1].ToString();
            progressBar1.PerformStep();
        }

        private void podgladPrzetwarzaniaObrazuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 okno2 = new Form2(this);
                okno2.Show();
                okno2.Uzupelnienie(wybranyodcisk);
                this.Hide();
            }
            catch 
            {    
                MessageBox.Show("Musisz najpierw wybrać odcisk palca zanim przejdziesz do okna drugiego");
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Czy chcesz zamknac aplikacje";
            string caption = "Zamykanie aplikacji";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.PerformStep();
                Przetwarzanie(wybranyodcisk);
                progressBar1.PerformStep();
                Neuronowe(wybranyodcisk);
                progressBar1.PerformStep();
                label1.Show();
                //progressBar1.Value = 0;
            }
            catch
            {
                MessageBox.Show("Najpier trzeba wybrać odcisk palca by później można było wczytać wyszukane odciski.");
                progressBar1.Value = 0;
            }
        }
    }
}
