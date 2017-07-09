using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Globalization; 
namespace P3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Globalna zmienna.
        /// </summary>
        public static string wybdat;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ustawienia dla menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edytujToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                if (wybdat != null)
                {
                    Form2 okno2 = new Form2(this);
                    okno2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Musisz najpierw wybrać datę"); 
                }
        }
        /// <summary>
        /// Ustawienia dla menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// Zamykanie Form1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Czy chcesz zamknac aplikacje";
            string caption = "Zamykanie aplikacji";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Obsługa ikonki kalendarza tak by naciśnięta data została przechowywana w naszej zmiennej globalnej.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    private void monthCalendar1_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
    {
        this.textBoxData.Text = e.Start.ToShortDateString();
        wybdat = Convert.ToString(textBoxData.Text);
    }
        /// <summary>
        /// Obsługa buttona ,,Edycja Wydarzeń". Uruchamia okno Form2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    private void buttonEdition_Click(object sender, EventArgs e)
    {
        if (wybdat != null)
        {
            Form2 okno2 = new Form2(this);
            okno2.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Musisz najpierw wybrać datę");
        }
    }
        /// <summary>
        ///  Obsługa buttona ,,Harmonogram". Uruchamia okno Form3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    private void buttonHarmonogram_Click(object sender, EventArgs e)
    {
        if (wybdat != null)
        {
        Form3 okno3 = new Form3(this);
        okno3.Show();
        this.Hide();
        }
        else
        {
            MessageBox.Show("Musisz najpierw wybrać datę");
        }
    }
        /// <summary>
        /// Ustawienia dla menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    private void harmonogramToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        if (wybdat != null)
        {
        Form3 okno3 = new Form3(this);
        okno3.Show();
        this.Hide();
         }
        else
        {
            MessageBox.Show("Musisz najpierw wybrać datę");
        }
    }


    }
}
