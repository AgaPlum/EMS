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
    public class Sieci
    {
        public int wys;//wysokość odcisków z neuro
        public int szer;//szerokość odcisków z neuro
        public int roz;//rozmiar dala wybranych odcisków z bazy
        public int cen;
        public int[] licz = new int[2];//obsługa liczby w bazie
        public Bitmap []wybrane=new Bitmap[2];//wygrane
        public int re;//zliczanie czerwonych puntów
        public int gr;//zliczanie zielonych punktów
        public Bitmap ala;
        public Bitmap bel;
        public Bitmap imge;// zmienna przyjmująca obraz z Odczytu
        public Bitmap[] obrazy;// tablica obrazów które będziemy porównywać
        public int[][] dane = new int[15][];// zapis wartości dla poszczególnych neuronów
        public System.Drawing.Image wybr;// jako globalna by móc w odczycie dobrze wybrać i jest to wybrany przez użytkownika odcisk
        public double[] output;
        public Bitmap[] Obsluga(System.Drawing.Image wybr,double [] input)
        {
            Odczyt(wybr);
            DoAn(obrazy);
            wybrane=Siec(input);
            return wybrane;
        }
        private int[][] DoAn(Bitmap[] obrazy)
        {
            for (int ob = 0; ob < 15; ob++)
            {
                Analiza(obrazy[ob]);
                dane[ob] = new int[6] { gr, re, wys, szer, roz, cen };
            }
            return dane;
        }
        /// <summary>
        /// Analiza obrazu pobranego z bazy
        /// </summary>
        /// <param name="image">przyjmowany parametr będzie kolejnym z tablicy z wczytywanych z Odczytu</param>
        private void Analiza(Bitmap image)
        {
            Obraz o = new Obraz();
            o.Metody(image);
            gr=o.Mgr;
            re=o.Mred;
            wys = o.wysokosc;
            szer = o.szerokosc;
            roz = o.Rozmiar;
            cen = o.cent;
        }
        /// <summary>
        /// Wczytanie obrazu
        /// </summary>
        private Bitmap[] Odczyt(System.Drawing.Image wybr)
        {
            try
            {
                obrazy = new Bitmap[15];
                for (int q = 0; q <= 14; q++)
                {
                        Bitmap image1 = (Bitmap)System.Drawing.Image.FromFile("BazaOdciskow\\LW_" + q + "a.bmp", true);
                        obrazy[q] = image1;
                }
                return obrazy;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Jest problem z otwarciem bitmapy." +
                 "Proszę sprawdź ścieżkę.");
                return null;
            }

        }
        /// <summary>
        /// Sieci neuronowe
        /// </summary>
        private Bitmap[] Siec(double[] input)
        {
            double[] wag = new double[15];
            output = new double[15];
            // wyciągnięcie cech z każdego obrazu i włożenie go do tablicy
            Bitmap[] neurony = Odczyt(wybr);// sieć nauronowa stworzona z zdjęć odcisków palca które będziemy porówbywać
            int[][] wartneuro = DoAn(neurony);//tablica przechowująca wartości dla każdego neuronu
            for (int z = 0; z < 15; z++)
            {
                wag[z] =( Math.Abs(input[0] - wartneuro[z][0]) + Math.Abs(input[1] - wartneuro[z][1]) 
                    + Math.Abs(input[2] - wartneuro[z][2]) + Math.Abs(input[3] - wartneuro[z][3])
                    + Math.Abs(input[4] - wartneuro[z][4])+ Math.Abs(input[5] - wartneuro[z][5]));
            }
            for (int z = 0; z < 15; z++)
            {
                output[z] = wag[z];
            }
            Array.Sort(output);
            for (int t = 0; t < 15; t++)
            {
                if (output[0] == wag[t])
                {
                    ala = neurony[t];
                    licz[0] = t;
                }
                if (output[1] == wag[t])
                {
                    bel = neurony[t];
                    licz[1] = t;
                }
            } 
            wybrane[0] = ala;
                wybrane[1] = bel;
            return wybrane;
        }
    }
}
