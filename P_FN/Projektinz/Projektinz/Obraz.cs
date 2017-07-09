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
    public class Obraz
    {
        private FiltersSequence filter = new FiltersSequence(Grayscale.CommonAlgorithms.BT709, new Threshold(64));
        public int[][] tablicag;//tablica zliczająca tylko rozgałęzienia
        public int re;//zliczanie czerwonych puntów
        public int gr;//zliczanie zielonych punktów
        public int rozmiar;//rozmiar dala wybranego odcisku
        public int wysokosc;//wysokość odciska
        public int szerokosc;//szerokość odciska
        public int cent;
        public Bitmap piaty;
        public int Mred
        {
            get { return re; }
            set { re = value; }
        }
        public int Mgr
        {
            get { return gr; }
            set { gr = value; }
        }
        public int[][] TabGr
        {
            get { return tablicag; }
            set { tablicag = value; }
        }
        public int Rozmiar
        {
            get { return rozmiar=szerokosc*wysokosc; }
            set { rozmiar = value; }
        }

        public void Metody(System.Drawing.Image im) 
        {
            Bitmap image = (Bitmap)im;
            Bitmap pierwszy=Media(image);
            Bitmap drugi = Test(pierwszy);
            Bitmap trzeci = Tot(drugi);
            Bitmap czwarty = Media(trzeci);
            piaty = Szkiel(czwarty);
            Wzor(piaty);
            rozmiar = Wys(czwarty) * Szer(czwarty);
            cent=Centroid(tablicag);
        }
        private Bitmap Media(Bitmap tempImage)
        {
            // tworzenie filtru
            Median filter = new Median();
            // wykorzystanie filtru
            filter.ApplyInPlace(tempImage);
            return tempImage;
        }
        private Bitmap Test(Bitmap tempImage)
        {
            Bitmap x = tempImage;
            int szer = x.Width;
            int dl = x.Height;

            Bitmap n = new Bitmap(szer, dl);

            int[,] dlaR = new int[szer, dl];
            int[,] dlaG = new int[szer, dl];
            int[,] dlaB = new int[szer, dl];

            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < dl; j++)
                {
                    dlaR[i, j] = x.GetPixel(i, j).R;
                    dlaG[i, j] = x.GetPixel(i, j).G;
                    dlaB[i, j] = x.GetPixel(i, j).B;
                }
            }

            ///funkcji Gaussa redukcja szumów filtr G 5X5
            for (int i = 2; i < x.Width - 2; i++)
            {
                for (int j = 2; j < x.Height - 2; j++)
                {
                    int a = 1;
                    int b = 1;
                    int c = 1;
                    int d = 15;
                    int e = 30;
                    int f = 45;


                    int red = (
                          ((dlaR[i - 2, j - 2]) * a + (dlaR[i - 1, j - 2]) * b + (dlaR[i, j - 2]) * c + (dlaR[i + 1, j - 2]) * b + (dlaR[i + 2, j - 2] * a)
                          + (dlaR[i - 2, j - 1]) * b + (dlaR[i - 1, j - 1]) * d + (dlaR[i, j - 1]) * e + (dlaR[i + 1, j - 1]) * d + (dlaR[i + 2, j - 1]) * b
                          + (dlaR[i - 2, j]) * c + (dlaR[i - 1, j]) * e + (dlaR[i, j]) * f + (dlaR[i + 1, j]) * e + (dlaR[i + 2, j]) * c
                          + (dlaR[i - 2, j + 1]) * b + (dlaR[i - 1, j + 1]) * d + (dlaR[i, j + 1]) * e + (dlaR[i + 1, j + 1]) * d + (dlaR[i + 2, j + 1]) * b
                          + (dlaR[i - 2, j + 2]) * a + (dlaR[i - 1, j + 2]) * b + (dlaR[i, j + 2]) * c + (dlaR[i + 1, j + 2]) * b + (dlaR[i + 2, j + 2]) * a) / 273
                          );

                    int green = (
                              ((dlaG[i - 2, j - 2]) * a + (dlaG[i - 1, j - 2]) * b + (dlaG[i, j - 2]) * c + (dlaG[i + 1, j - 2]) * b + (dlaG[i + 2, j - 2] * a)
                              + (dlaG[i - 2, j - 1]) * b + (dlaG[i - 1, j - 1]) * d + (dlaG[i, j - 1]) * e + (dlaG[i + 1, j - 1]) * d + (dlaG[i + 2, j - 1]) * b
                              + (dlaG[i - 2, j]) * c + (dlaG[i - 1, j]) * e + (dlaG[i, j]) * f + (dlaG[i + 1, j]) * e + (dlaG[i + 2, j]) * c
                              + (dlaG[i - 2, j + 1]) * b + (dlaG[i - 1, j + 1]) * d + (dlaG[i, j + 1]) * e + (dlaG[i + 1, j + 1]) * d + (dlaG[i + 2, j + 1]) * b
                              + (dlaG[i - 2, j + 2]) * a + (dlaG[i - 1, j + 2]) * b + (dlaG[i, j + 2]) * c + (dlaG[i + 1, j + 2]) * b + (dlaG[i + 2, j + 2]) * a) / 273
                              );

                    int blue = (
                              ((dlaB[i - 2, j - 2]) * a + (dlaB[i - 1, j - 2]) * b + (dlaB[i, j - 2]) * c + (dlaB[i + 1, j - 2]) * b + (dlaB[i + 2, j - 2] * a)
                              + (dlaB[i - 2, j - 1]) * b + (dlaB[i - 1, j - 1]) * d + (dlaB[i, j - 1]) * e + (dlaB[i + 1, j - 1]) * d + (dlaB[i + 2, j - 1]) * b
                              + (dlaB[i - 2, j]) * c + (dlaB[i - 1, j]) * e + (dlaB[i, j]) * f + (dlaB[i + 1, j]) * e + (dlaB[i + 2, j]) * c
                              + (dlaB[i - 2, j + 1]) * b + (dlaB[i - 1, j + 1]) * d + (dlaB[i, j + 1]) * e + (dlaB[i + 1, j + 1]) * d + (dlaB[i + 2, j + 1]) * b
                              + (dlaB[i - 2, j + 2]) * a + (dlaB[i - 1, j + 2]) * b + (dlaB[i, j + 2]) * c + (dlaB[i + 1, j + 2]) * b + (dlaB[i + 2, j + 2]) * a) / 273
                              );
                    n.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            return n;
        }
        private Bitmap Tot(Bitmap tempImage)
        {
            Threshold fil = new Threshold(200);
            Bitmap image = AForge.Imaging.Image.Clone(tempImage, PixelFormat.Format24bppRgb);
            Bitmap gsImage = filter.Apply(image);
            fil.ApplyInPlace(gsImage);
            return gsImage;
        }
        private Bitmap Szkiel(Bitmap tempImage)
        {
            ///Szkieletyzacja
            SimpleSkeletonization skiel = new SimpleSkeletonization();
            Bitmap image = AForge.Imaging.Image.Clone(tempImage, PixelFormat.Format24bppRgb);
            Bitmap gsImage = filter.Apply(image);
            skiel.ApplyInPlace(gsImage);
            Bitmap IndexedImage = new Bitmap(gsImage);
            Bitmap bit = IndexedImage.Clone(new Rectangle(0, 0, IndexedImage.Width, IndexedImage.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int x = 0; x < bit.Width; x++)
            {
                for (int y = 0; y < bit.Height; y++)
                {
                    if (bit.GetPixel(x, y).R == 0 && bit.GetPixel(x, y).G == 0 && bit.GetPixel(x, y).B == 0)
                    { bit.SetPixel(x, y, Color.White); }
                    else
                    { bit.SetPixel(x, y, Color.Black); }
                }
            }
            return bit;
        }
        public void Wzor(Bitmap tempImage)
        {
            Graphics g = Graphics.FromImage(tempImage);
            // bitmapa na ktora bedziemy zapisywac
            Bitmap image = (Bitmap)tempImage.Clone();
            // zablokowanie bitmap
            BitmapData imageData = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
            tablicag = new int[30][];
            Pen rePe = new Pen(System.Drawing.Color.Red, 3);
            Pen grPe = new Pen(System.Drawing.Color.Green, 3);
            image.UnlockBits(imageData);
            int[] tap = new int[500];
            int[] tab = new int[8];
            re = 0;
            gr = 0;
            double w;
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pi = image.GetPixel(x, y);
                    int k = (int)(0.299 * pi.R + 0.587 * pi.G + 0.114 * pi.B);
                    if (k == 0)
                    {
                        try
                        {
                            tab[0] = (int)(0.299 * image.GetPixel(x - 1, y).R + 0.587 * image.GetPixel(x - 1, y).G + 0.114 * image.GetPixel(x - 1, y).B)
                                    - (int)(0.299 * image.GetPixel(x - 1, y - 1).R + 0.587 * image.GetPixel(x - 1, y - 1).G + 0.114 * image.GetPixel(x - 1, y - 1).B);
                            tab[0] = Math.Abs(tab[0]);
                        }
                        catch
                        {
                            tab[0] = 0;
                        }
                        try
                        {
                            tab[1] = (int)(0.299 * image.GetPixel(x - 1, y - 1).R + 0.587 * image.GetPixel(x - 1, y - 1).G + 0.114 * image.GetPixel(x - 1, y - 1).B)
                                    - (int)(0.299 * image.GetPixel(x, y - 1).R + 0.587 * image.GetPixel(x, y - 1).G + 0.114 * image.GetPixel(x, y - 1).B);
                            tab[1] = Math.Abs(tab[1]);
                        }
                        catch
                        {
                            tab[1] = 0;
                        }
                        try
                        {
                            tab[2] = (int)(0.299 * image.GetPixel(x, y - 1).R + 0.587 * image.GetPixel(x, y - 1).G + 0.114 * image.GetPixel(x, y - 1).B)
                                    - (int)(0.299 * image.GetPixel(x + 1, y - 1).R + 0.587 * image.GetPixel(x + 1, y - 1).G + 0.114 * image.GetPixel(x + 1, y - 1).B);
                            tab[2] = Math.Abs(tab[2]);
                        }
                        catch
                        {
                            tab[2] = 0;
                        }
                        try
                        {
                            tab[3] = (int)(0.299 * image.GetPixel(x + 1, y - 1).R + 0.587 * image.GetPixel(x + 1, y - 1).G + 0.114 * image.GetPixel(x + 1, y - 1).B)
                                    - (int)(0.299 * image.GetPixel(x + 1, y).R + 0.587 * image.GetPixel(x + 1, y).G + 0.114 * image.GetPixel(x + 1, y).B);
                            tab[3] = Math.Abs(tab[3]);
                        }
                        catch
                        {
                            tab[3] = 0;
                        }
                        try
                        {
                            tab[4] = (int)(0.299 * image.GetPixel(x + 1, y).R + 0.587 * image.GetPixel(x + 1, y).G + 0.114 * image.GetPixel(x + 1, y).B)
                                    - (int)(0.299 * image.GetPixel(x + 1, y + 1).R + 0.587 * image.GetPixel(x + 1, y + 1).G + 0.114 * image.GetPixel(x + 1, y + 1).B);
                            tab[4] = Math.Abs(tab[4]);
                        }
                        catch
                        {
                            tab[4] = 0;
                        }
                        try
                        {
                            tab[5] = (int)(0.299 * image.GetPixel(x + 1, y + 1).R + 0.587 * image.GetPixel(x + 1, y + 1).G + 0.114 * image.GetPixel(x + 1, y + 1).B)
                          - (int)(0.299 * image.GetPixel(x, y + 1).R + 0.587 * image.GetPixel(x, y + 1).G + 0.114 * image.GetPixel(x, y + 1).B);
                            tab[5] = Math.Abs(tab[5]);
                        }
                        catch
                        {
                            tab[5] = 0;
                        }
                        try
                        {
                            tab[6] = (int)(0.299 * image.GetPixel(x, y + 1).R + 0.587 * image.GetPixel(x, y + 1).G + 0.114 * image.GetPixel(x, y + 1).B)
                          - (int)(0.299 * image.GetPixel(x - 1, y + 1).R + 0.587 * image.GetPixel(x - 1, y + 1).G + 0.114 * image.GetPixel(x - 1, y + 1).B);
                            tab[6] = Math.Abs(tab[6]);
                        }
                        catch
                        {
                            tab[6] = 0;
                        }
                        try
                        {
                            tab[7] = (int)(0.299 * image.GetPixel(x - 1, y + 1).R + 0.587 * image.GetPixel(x - 1, y + 1).G + 0.114 * image.GetPixel(x - 1, y + 1).B)
                                - (int)(0.299 * image.GetPixel(x - 1, y).R + 0.587 * image.GetPixel(x - 1, y).G + 0.114 * image.GetPixel(x - 1, y).B);
                            tab[7] = Math.Abs(tab[7]);
                        }
                        catch
                        {
                            tab[7] = 0;
                        }


                        w = (0.5 * (tab[0] + tab[1] + tab[2] + tab[3] + tab[4] + tab[5] + tab[6] + tab[7]));
                        if (w == 255.0)
                        {
                            Rectangle myRectangle = new Rectangle(x, y, 1, 1);
                            g.DrawEllipse(rePe, myRectangle);

                            re++;

                        }
                        if (w == 765.0)
                        {
                            Rectangle myRectangle = new Rectangle(x, y, 1, 1);
                            g.DrawEllipse(grPe, myRectangle);
                            for (int n = gr; n < 30; n++)
                            {
                                tablicag[n] = new int[2] { x, y };
                                break;
                            }
                            gr++;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Obliczanie wysokości
        /// </summary>
        private int Wys(Bitmap tempImage)
        {
            Bitmap obraz = tempImage;
            int z = 0;
            int[][] tablica = new int[obraz.Height * obraz.Width][];
            int dl = tablica.Length;
            for (int w = 0; w < obraz.Height; w++)
            {
                for (int s = 0; s < obraz.Width; s++)
                {
                    Color pi = (Color)obraz.GetPixel(s, w);
                    int k = (int)(0.299 * pi.R + 0.587 * pi.G + 0.114 * pi.B);
                    if (k == 255)
                    {

                        for (int m = z; m < dl; m++)
                        {
                            tablica[m] = new int[2] { s, w };
                            break;
                        }
                        z++;

                    }

                }
            }
            int x1 = tablica[obraz.Width / 2][0];
            int y1 = tablica[obraz.Width / 2][1];
            //int x1 = tablica[tablica.Length / 2][0];
            //int y1 = tablica[tablica.Length / 2][1];
            int c = 0;
            int t = 0;
            {
                for (t = 0; t < dl; t++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (tablica[t] == null)
                        {
                            c = t;
                            i = 2;
                            t = dl;
                        }
                    }
                }
            }
            int x2 = x1;
            int y2 = tablica[c - 1][1];
            wysokosc = (int)Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return wysokosc;
        }
        /// <summary>
        /// obliczanie szerokości
        /// </summary>
        private int Szer(Bitmap tempImage)
        {
            Bitmap obraz = tempImage;
            int z = 0;
            int[][] tablica = new int[obraz.Height * obraz.Width][];
            int dl = tablica.Length;
            for (int w = 0; w < obraz.Height; w++)
            {
                for (int s = 0; s < obraz.Width; s++)
                {
                    Color pi = (Color)obraz.GetPixel(s, w);
                    int k = (int)(0.299 * pi.R + 0.587 * pi.G + 0.114 * pi.B);
                    if (k == 255)
                    {

                        for (int m = z; m < dl; m++)
                        {
                            tablica[m] = new int[2] { s, w };

                            break;
                        }
                        z++;

                    }

                }
            }
            int x1 = tablica[obraz.Height / 2][0];
            int y1 = tablica[obraz.Height / 2][1];
            //int x1 = tablica[tablica.Length / 2][0];
            //int y1 = tablica[tablica.Length / 2][1];
            int c = 0;
            int t = 0;
            {
                for (t = 0; t < dl; t++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (tablica[t] == null)
                        {
                            c = t;
                            i = 2;
                            t = dl;
                        }
                    }
                }
            }
            int x2 = tablica[c - 1][0];
            int y2 = y1;
            szerokosc = (int)Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return szerokosc;
        }
        private int Centroid(int[][] tablicag)
        {
            double[] odcinki = new double[29];
            double am = 0; ;
            for (int p = 0; p < 29; p++)
            {
                int d = tablicag[p][0];
                int s = tablicag[p][1];
                int da = tablicag[p + 1][0];
                int sa = tablicag[p + 1][1];
                double odci = Math.Sqrt(((d - da) * (d - da)) + ((s - sa) * (s - sa)));
                odcinki[p] = odci;
            }
            for (int daa = 0; daa < 29; daa++)
            {
                am = odcinki[daa] + am;
            }
            cent = (int)am / 29;
            return cent;
        }
    }
}
