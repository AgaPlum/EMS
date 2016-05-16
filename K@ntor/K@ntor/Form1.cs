using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace K_ntor
{
    public partial class Form1 : Form
    {
        Table t = new Table();
        public string[,] tab;
        public Form1()
        {

            InitializeComponent();
            comboBox1.Items.Add("Euro");
            comboBox1.Items.Add("US Dollar");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //Filling CB2 with currency full name
        public void CBI1(string[,] tab)
        {
            try
            {
                for (int j = 0; j < 31; j++)
                {
                    comboBox2.Items.Add(tab[j, 0]);
                }
            }
            catch
            {
                MessageBox.Show("Please try to choose one more time");
            }
        }
        //Event for CB1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            label5.Text = "";
            string ct = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            comboBox2.Items.Clear();
            //string[,]tab;
            Uri url;
            if (ct == "Euro")
            {
                url = new Uri(@"http://api.fixer.io/latest");
                tab = t.DataDownload(url);
                CBI1(tab);
            }
            else
            {
                url = new Uri(@"http://api.fixer.io/latest?base=USD");
                tab = t.DataDownload(url);
                CBI1(tab);
            }
        }
        //Event for CB2
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cb = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
            string []final =t.Chosen(cb, tab);
            label1.Text = final[0];
            label5.Text = final[1];
            
        }
        //Event for closing app
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Would you like to close application?";
            string caption = "Closing application;../";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }
        
        }
    }
}
