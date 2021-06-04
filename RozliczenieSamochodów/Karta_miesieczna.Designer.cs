
namespace RozliczenieSamochodów
{
    partial class Karta_miesieczna
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_przejazdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzieńMiesiącaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celwyjazduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanlicznikaprzywyjeździeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanlicznikapopowrocieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćprzejechanychkmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przejazdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.użytkownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przejazdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.użytkownicyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_przejazdu,
            this.dzieńMiesiącaDataGridViewTextBoxColumn,
            this.idpracownikaDataGridViewTextBoxColumn,
            this.celwyjazduDataGridViewTextBoxColumn,
            this.trasaDataGridViewTextBoxColumn,
            this.stanlicznikaprzywyjeździeDataGridViewTextBoxColumn,
            this.stanlicznikapopowrocieDataGridViewTextBoxColumn,
            this.ilośćprzejechanychkmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.przejazdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(997, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id_przejazdu
            // 
            this.Id_przejazdu.DataPropertyName = "Id_przejazdu";
            this.Id_przejazdu.Frozen = true;
            this.Id_przejazdu.HeaderText = "Id_przejazdu";
            this.Id_przejazdu.Name = "Id_przejazdu";
            this.Id_przejazdu.ReadOnly = true;
            this.Id_przejazdu.Width = 92;
            // 
            // dzieńMiesiącaDataGridViewTextBoxColumn
            // 
            this.dzieńMiesiącaDataGridViewTextBoxColumn.DataPropertyName = "Dzień_Miesiąca";
            this.dzieńMiesiącaDataGridViewTextBoxColumn.Frozen = true;
            this.dzieńMiesiącaDataGridViewTextBoxColumn.HeaderText = "Dzień_Miesiąca";
            this.dzieńMiesiącaDataGridViewTextBoxColumn.Name = "dzieńMiesiącaDataGridViewTextBoxColumn";
            this.dzieńMiesiącaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dzieńMiesiącaDataGridViewTextBoxColumn.Width = 107;
            // 
            // idpracownikaDataGridViewTextBoxColumn
            // 
            this.idpracownikaDataGridViewTextBoxColumn.DataPropertyName = "Id_pracownika";
            this.idpracownikaDataGridViewTextBoxColumn.HeaderText = "Id_pracownika";
            this.idpracownikaDataGridViewTextBoxColumn.Name = "idpracownikaDataGridViewTextBoxColumn";
            this.idpracownikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpracownikaDataGridViewTextBoxColumn.Width = 102;
            // 
            // celwyjazduDataGridViewTextBoxColumn
            // 
            this.celwyjazduDataGridViewTextBoxColumn.DataPropertyName = "Cel_wyjazdu";
            this.celwyjazduDataGridViewTextBoxColumn.HeaderText = "Cel_wyjazdu";
            this.celwyjazduDataGridViewTextBoxColumn.Name = "celwyjazduDataGridViewTextBoxColumn";
            this.celwyjazduDataGridViewTextBoxColumn.ReadOnly = true;
            this.celwyjazduDataGridViewTextBoxColumn.Width = 91;
            // 
            // trasaDataGridViewTextBoxColumn
            // 
            this.trasaDataGridViewTextBoxColumn.DataPropertyName = "Trasa";
            this.trasaDataGridViewTextBoxColumn.HeaderText = "Trasa";
            this.trasaDataGridViewTextBoxColumn.Name = "trasaDataGridViewTextBoxColumn";
            this.trasaDataGridViewTextBoxColumn.ReadOnly = true;
            this.trasaDataGridViewTextBoxColumn.Width = 59;
            // 
            // stanlicznikaprzywyjeździeDataGridViewTextBoxColumn
            // 
            this.stanlicznikaprzywyjeździeDataGridViewTextBoxColumn.DataPropertyName = "Stan_licznika_przy_wyjeździe";
            this.stanlicznikaprzywyjeździeDataGridViewTextBoxColumn.HeaderText = "Stan_licznika_przy_wyjeździe";
            this.stanlicznikaprzywyjeździeDataGridViewTextBoxColumn.Name = "stanlicznikaprzywyjeździeDataGridViewTextBoxColumn";
            this.stanlicznikaprzywyjeździeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanlicznikaprzywyjeździeDataGridViewTextBoxColumn.Width = 171;
            // 
            // stanlicznikapopowrocieDataGridViewTextBoxColumn
            // 
            this.stanlicznikapopowrocieDataGridViewTextBoxColumn.DataPropertyName = "Stan_licznika_po_powrocie";
            this.stanlicznikapopowrocieDataGridViewTextBoxColumn.HeaderText = "Stan_licznika_po_powrocie";
            this.stanlicznikapopowrocieDataGridViewTextBoxColumn.Name = "stanlicznikapopowrocieDataGridViewTextBoxColumn";
            this.stanlicznikapopowrocieDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanlicznikapopowrocieDataGridViewTextBoxColumn.Width = 162;
            // 
            // ilośćprzejechanychkmDataGridViewTextBoxColumn
            // 
            this.ilośćprzejechanychkmDataGridViewTextBoxColumn.DataPropertyName = "Ilość_przejechanych_km_";
            this.ilośćprzejechanychkmDataGridViewTextBoxColumn.HeaderText = "Ilość_przejechanych_km_";
            this.ilośćprzejechanychkmDataGridViewTextBoxColumn.Name = "ilośćprzejechanychkmDataGridViewTextBoxColumn";
            this.ilośćprzejechanychkmDataGridViewTextBoxColumn.ReadOnly = true;
            this.ilośćprzejechanychkmDataGridViewTextBoxColumn.Width = 155;
            // 
            // przejazdBindingSource
            // 
            this.przejazdBindingSource.DataSource = typeof(RozliczenieSamochodów.DataModel.Przejazd);
            this.przejazdBindingSource.CurrentChanged += new System.EventHandler(this.przejazdBindingSource_CurrentChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.użytkownicyBindingSource;
            this.listBox1.DisplayMember = "Id_pracownika";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(47, 388);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 43);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "Id_pracownika";
            // 
            // użytkownicyBindingSource
            // 
            this.użytkownicyBindingSource.DataSource = typeof(RozliczenieSamochodów.DataModel.Użytkownicy);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(173, 389);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "prywatny";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(173, 414);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "służbowy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dzień";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pracownik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cel wyjazdu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trasa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 389);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 42);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(476, 389);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(476, 437);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stan licznika przed wyjazdem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stan licznika po powrocie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(728, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Usuń wybrane wiersze";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(12, 22);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(43, 13);
            this.month.TabIndex = 17;
            this.month.Text = "Miesiąc";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(62, 22);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(27, 13);
            this.year.TabIndex = 18;
            this.year.Text = "Rok";
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.Location = new System.Drawing.Point(117, 22);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(79, 13);
            this.reg.TabIndex = 19;
            this.reg.Text = "Nr rejestracyjny";
            // 
            // Karta_miesieczna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 515);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Karta_miesieczna";
            this.Text = "Karta Miesięczna";
            this.Load += new System.EventHandler(this.Karta_miesieczna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przejazdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.użytkownicyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource przejazdBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource użytkownicyBindingSource;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_przejazdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzieńMiesiącaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celwyjazduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanlicznikaprzywyjeździeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanlicznikapopowrocieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćprzejechanychkmDataGridViewTextBoxColumn;
    }
}