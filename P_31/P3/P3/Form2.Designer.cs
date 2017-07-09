namespace P3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.buttonNewOne = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelOpportunity = new System.Windows.Forms.Label();
            this.labelValidity = new System.Windows.Forms.Label();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.comboBoxOpportunity = new System.Windows.Forms.ComboBox();
            this.comboBoxValidity = new System.Windows.Forms.ComboBox();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.buttonPut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewOne
            // 
            this.buttonNewOne.Location = new System.Drawing.Point(582, 300);
            this.buttonNewOne.Name = "buttonNewOne";
            this.buttonNewOne.Size = new System.Drawing.Size(98, 38);
            this.buttonNewOne.TabIndex = 23;
            this.buttonNewOne.Text = "Nowe";
            this.buttonNewOne.UseVisualStyleBackColor = true;
            this.buttonNewOne.Click += new System.EventHandler(this.buttonNewOne_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(605, 246);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelOpportunity
            // 
            this.labelOpportunity.AutoSize = true;
            this.labelOpportunity.Location = new System.Drawing.Point(437, 370);
            this.labelOpportunity.Name = "labelOpportunity";
            this.labelOpportunity.Size = new System.Drawing.Size(40, 13);
            this.labelOpportunity.TabIndex = 21;
            this.labelOpportunity.Text = "Okazja";
            // 
            // labelValidity
            // 
            this.labelValidity.AutoSize = true;
            this.labelValidity.Location = new System.Drawing.Point(437, 280);
            this.labelValidity.Name = "labelValidity";
            this.labelValidity.Size = new System.Drawing.Size(52, 13);
            this.labelValidity.TabIndex = 20;
            this.labelValidity.Text = "Ważność";
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Location = new System.Drawing.Point(40, 328);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(63, 13);
            this.labelEvent.TabIndex = 19;
            this.labelEvent.Text = "Wydarzenie";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(43, 256);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(46, 13);
            this.labelHour.TabIndex = 18;
            this.labelHour.Text = "Godzina";
            // 
            // comboBoxOpportunity
            // 
            this.comboBoxOpportunity.FormattingEnabled = true;
            this.comboBoxOpportunity.Items.AddRange(new object[] {
            "Urodziny",
            "Imieniny",
            "Spotkanie",
            "Wesele",
            "Narodziny",
            "Pogrzeb",
            "Inne"});
            this.comboBoxOpportunity.Location = new System.Drawing.Point(398, 393);
            this.comboBoxOpportunity.Name = "comboBoxOpportunity";
            this.comboBoxOpportunity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOpportunity.TabIndex = 17;
            // 
            // comboBoxValidity
            // 
            this.comboBoxValidity.FormattingEnabled = true;
            this.comboBoxValidity.Items.AddRange(new object[] {
            "+++",
            "++",
            "+"});
            this.comboBoxValidity.Location = new System.Drawing.Point(398, 320);
            this.comboBoxValidity.Name = "comboBoxValidity";
            this.comboBoxValidity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxValidity.TabIndex = 16;
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Location = new System.Drawing.Point(43, 344);
            this.textBoxEvent.Multiline = true;
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(298, 85);
            this.textBoxEvent.TabIndex = 15;
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(43, 280);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(106, 20);
            this.textBoxHour.TabIndex = 14;
            this.textBoxHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHour_KeyPress);
            // 
            // buttonPut
            // 
            this.buttonPut.Location = new System.Drawing.Point(582, 344);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(98, 54);
            this.buttonPut.TabIndex = 13;
            this.buttonPut.Text = "Wstaw";
            this.buttonPut.UseVisualStyleBackColor = true;
            this.buttonPut.Click += new System.EventHandler(this.buttonPut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(43, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 197);
            this.dataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Wpisz godzinę w postaci HH:MM";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewOne);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelOpportunity);
            this.Controls.Add(this.labelValidity);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.comboBoxOpportunity);
            this.Controls.Add(this.comboBoxValidity);
            this.Controls.Add(this.textBoxEvent);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.buttonPut);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewOne;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelOpportunity;
        private System.Windows.Forms.Label labelValidity;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.ComboBox comboBoxOpportunity;
        private System.Windows.Forms.ComboBox comboBoxValidity;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.Button buttonPut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}