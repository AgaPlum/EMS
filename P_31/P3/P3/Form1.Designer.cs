namespace P3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harmonogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEdition = new System.Windows.Forms.Button();
            this.buttonHarmonogram = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytujToolStripMenuItem,
            this.harmonogramToolStripMenuItem1,
            this.zakończToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.edytujToolStripMenuItem.Text = "Edytuj ";
            this.edytujToolStripMenuItem.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click_1);
            // 
            // harmonogramToolStripMenuItem1
            // 
            this.harmonogramToolStripMenuItem1.Name = "harmonogramToolStripMenuItem1";
            this.harmonogramToolStripMenuItem1.Size = new System.Drawing.Size(98, 20);
            this.harmonogramToolStripMenuItem1.Text = "Harmonogram";
            this.harmonogramToolStripMenuItem1.Click += new System.EventHandler(this.harmonogramToolStripMenuItem1_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(18, 300);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(100, 20);
            this.textBoxData.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 84);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wybierz datę z kalendarza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wybrałeś/aś datę:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jeżeli chcesz wpisać wydarzenie naciśnij:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jeżeli chcesz zobaczyć jakie masz plany na wybrany dzien naciśnij:";
            // 
            // buttonEdition
            // 
            this.buttonEdition.Location = new System.Drawing.Point(243, 101);
            this.buttonEdition.Name = "buttonEdition";
            this.buttonEdition.Size = new System.Drawing.Size(144, 52);
            this.buttonEdition.TabIndex = 10;
            this.buttonEdition.Text = "Edycja Wydarzeń";
            this.buttonEdition.UseVisualStyleBackColor = true;
            this.buttonEdition.Click += new System.EventHandler(this.buttonEdition_Click);
            // 
            // buttonHarmonogram
            // 
            this.buttonHarmonogram.Location = new System.Drawing.Point(243, 228);
            this.buttonHarmonogram.Name = "buttonHarmonogram";
            this.buttonHarmonogram.Size = new System.Drawing.Size(179, 69);
            this.buttonHarmonogram.TabIndex = 11;
            this.buttonHarmonogram.Text = "Harmonogram";
            this.buttonHarmonogram.UseVisualStyleBackColor = true;
            this.buttonHarmonogram.Click += new System.EventHandler(this.buttonHarmonogram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 339);
            this.Controls.Add(this.buttonHarmonogram);
            this.Controls.Add(this.buttonEdition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEdition;
        private System.Windows.Forms.Button buttonHarmonogram;
        private System.Windows.Forms.ToolStripMenuItem harmonogramToolStripMenuItem1;
    }
}

