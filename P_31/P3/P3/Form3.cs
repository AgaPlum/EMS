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
    public partial class Form3 : Form
    {
        /// <summary>
        /// Zmienne globalne.
        /// </summary>
        public static string kom; 
        private Form1 rodzic;
        /// <summary>
        /// Konstruktor dzięki któremu udało się ustalić by okno Form2 było podległe oknu Form1.
        /// </summary>
        /// Prywatna zmienna rodzic.
        /// <param name="rodzic"></param>
        public Form3(Form1 rodzic)
        {
            InitializeComponent();
            this.rodzic = rodzic;
        }
        /// <summary>
        /// Ustawienia dla menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Czy chcesz zamknąć cały program";
            string caption = "Zamykanie aplikacji";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                  Environment.Exit(0);
            }
          
        }
        /// <summary>
        /// Po zamknięciu Form3 następuje przekierowanie do okna rodzic czyli Form1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            rodzic.Show();
        }
        /// <summary>
        /// Ustawienia dla menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oknoGłówneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rodzic.Show();
            this.Close();
        }
        /// <summary>
        /// Po otwarciu okna Form3 czyli naszego okna harmonogramu od razu łączy się z bazą danych. Wykorzystuje zmienną globalną kom oraz wybdat która została utworzona w Form1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {
             PolaczBaza.Polancz();
            kom = ("SELECT *From Zdarzenia WHERE Dzień='" + Form1.wybdat + "'");
            this.dataGridView1.AutoGenerateColumns = true;
            this.bindingSource1.DataSource = PolaczBaza.Select(kom);
           
        }
    }
}
