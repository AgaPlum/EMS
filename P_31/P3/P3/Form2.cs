using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace P3
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Zmienne globalne
        /// </summary>
        public static SqlCeDataAdapter datAda;
        public static DataSet datSet;
        public static DataRow datRw;
        public static string komenda = ("SELECT *From Zdarzenia ");
        private Form1 rodzic;

        /// <summary>
        /// Konstruktor dzięki któremu udało się ustalić by okno Form2 było podległe oknu Form1.
        /// </summary>
        /// Prywatna zmienna rodzic.
        /// <param name="rodzic"></param>
        public Form2(Form1 rodzic)
        {
            InitializeComponent();
            this.rodzic = rodzic;
        }
        /// <summary>
        /// Po otwarciu okna Form2 czyli naszego okna do edycji od razu łączy się z bazą danych. Wykorzystuje zmienną globalną komenda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            PolaczBaza.Polancz();

            SqlCeCommand command = new SqlCeCommand(komenda, PolaczBaza.pol);
            datSet = new DataSet();
            datAda = new SqlCeDataAdapter(command);
            datAda.Fill(datSet, "Zdarzenia");
        }
        /// <summary>
        /// Prywatna metoda mająca na celu odświeżenie bazy danych czyli ponowne jej załadowanie z uwzględnieniem zmian.
        /// </summary>
        private void Odswierzenie()
        {
            this.dataGridView1.AutoGenerateColumns = true;
            this.bindingSource1.DataSource = PolaczBaza.Select(komenda);
        }
        /// <summary>
        /// Po zamknięciu Form2 następuje przekierowanie do okna rodzic czyli Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            rodzic.Show();
        }
        /// <summary>
        /// Obsługa buttona ,,Wstaw".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPut_Click(object sender, EventArgs e)
        {
            datRw = datSet.Tables["Zdarzenia"].NewRow();
            datRw["Dzień"] = Form1.wybdat;
            datRw["Godzina"] = this.textBoxHour.Text;
            datRw["Wydarzenie"] = this.textBoxEvent.Text;
            datRw["Okazja"] = this.comboBoxOpportunity.SelectedItem;
            datRw["Ważność"] = this.comboBoxValidity.SelectedItem;
            datSet.Tables["Zdarzenia"].Rows.Add(datRw);
            SqlCeCommandBuilder cb = new SqlCeCommandBuilder(datAda);
            datAda.Update(datSet, "Zdarzenia");
            Odswierzenie();
        }
        /// <summary>
        /// Obsługa buttona ,,Nowe"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewOne_Click(object sender, EventArgs e)
        {
            this.textBoxEvent.Clear();
            this.textBoxHour.Clear();
            this.comboBoxOpportunity.SelectedIndex = -1;
            this.comboBoxValidity.SelectedIndex = -1;
        }
        /// <summary>
        /// Obsługa buttona ,,Zapisz"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int zmiana = 0;
            foreach (DataRow datRw in datSet.Tables["Zdarzenia"].Rows)
            {
                if (datRw.RowState == DataRowState.Modified)
                {
                    zmiana++;
                }
            }
            if (zmiana != 0)
            {
                DialogResult digRet = MessageBox.Show(String.Format("Zmodyfikowano {0} rekordów", zmiana), "Aktualizacja bazy danych", MessageBoxButtons.OKCancel);
                if (digRet == DialogResult.OK)
                {
                    try
                    {
                        SqlCeCommandBuilder cmdBuilder = new SqlCeCommandBuilder(datAda);
                        datAda.Update(datSet, "Zdarzenia");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            
          
        }
        /// <summary>
        /// Obsługa dla textBoxa gdzie wpisywana jest godzina. Ustawione są parametry jakie textBox może przyjmować.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            
              if (!Char.IsNumber(e.KeyChar) && e.KeyChar != ':')
                { e.Handled = true; }
        
        } 
    }
}
