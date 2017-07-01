namespace KOLOKWIUM_OKIENKA
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.But_szuakaj = new System.Windows.Forms.Button();
            this.but_usu = new System.Windows.Forms.Button();
            this.but_dodOcen = new System.Windows.Forms.Button();
            this.but_odsw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_czysc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imie,
            this.nazwisko,
            this.index,
            this.data});
            this.grid1.Location = new System.Drawing.Point(22, 183);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(691, 254);
            this.grid1.TabIndex = 0;
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
            // 
            // imie
            // 
            this.imie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imie.HeaderText = "Imię";
            this.imie.Name = "imie";
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwisko.HeaderText = "Nazwisko";
            this.nazwisko.Name = "nazwisko";
            // 
            // index
            // 
            this.index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.index.HeaderText = "Indeks";
            this.index.Name = "index";
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data.HeaderText = "Data Urodzenia";
            this.data.Name = "data";
            // 
            // But_szuakaj
            // 
            this.But_szuakaj.Location = new System.Drawing.Point(27, 111);
            this.But_szuakaj.Name = "But_szuakaj";
            this.But_szuakaj.Size = new System.Drawing.Size(107, 38);
            this.But_szuakaj.TabIndex = 1;
            this.But_szuakaj.Text = "Search student";
            this.But_szuakaj.UseVisualStyleBackColor = true;
            this.But_szuakaj.Click += new System.EventHandler(this.But_szuakaj_Click);
            // 
            // but_usu
            // 
            this.but_usu.Location = new System.Drawing.Point(154, 23);
            this.but_usu.Name = "but_usu";
            this.but_usu.Size = new System.Drawing.Size(108, 38);
            this.but_usu.TabIndex = 2;
            this.but_usu.Text = "Remove student";
            this.but_usu.UseVisualStyleBackColor = true;
            this.but_usu.Click += new System.EventHandler(this.but_usu_Click);
            // 
            // but_dodOcen
            // 
            this.but_dodOcen.Location = new System.Drawing.Point(155, 111);
            this.but_dodOcen.Name = "but_dodOcen";
            this.but_dodOcen.Size = new System.Drawing.Size(108, 38);
            this.but_dodOcen.TabIndex = 3;
            this.but_dodOcen.Text = "Add mark";
            this.but_dodOcen.UseVisualStyleBackColor = true;
            this.but_dodOcen.Click += new System.EventHandler(this.but_dodOcen_Click);
            // 
            // but_odsw
            // 
            this.but_odsw.Location = new System.Drawing.Point(273, 89);
            this.but_odsw.Name = "but_odsw";
            this.but_odsw.Size = new System.Drawing.Size(105, 23);
            this.but_odsw.TabIndex = 5;
            this.but_odsw.Text = "Refresh";
            this.but_odsw.UseVisualStyleBackColor = true;
            this.but_odsw.Click += new System.EventHandler(this.but_odsw_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_czysc
            // 
            this.but_czysc.Location = new System.Drawing.Point(27, 23);
            this.but_czysc.Name = "but_czysc";
            this.but_czysc.Size = new System.Drawing.Size(107, 38);
            this.but_czysc.TabIndex = 7;
            this.but_czysc.Text = "Clear a student list";
            this.but_czysc.UseVisualStyleBackColor = true;
            this.but_czysc.Click += new System.EventHandler(this.but_czysc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Remove choosen student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 60);
            this.button3.TabIndex = 9;
            this.button3.Text = "Show marks a chosen student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Save to txt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Read from txt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Serialize";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 114);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Deserialize";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(119, 18);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(161, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "save to txt - dialog window";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(119, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(161, 23);
            this.button10.TabIndex = 15;
            this.button10.Text = "read from txt - dialog window";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_czysc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.but_odsw);
            this.groupBox1.Controls.Add(this.But_szuakaj);
            this.groupBox1.Controls.Add(this.but_usu);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.but_dodOcen);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edycja";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(409, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 160);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(251, 471);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(195, 23);
            this.button11.TabIndex = 18;
            this.button11.Text = "Exit without a save changing";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 548);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Button But_szuakaj;
        private System.Windows.Forms.Button but_usu;
        private System.Windows.Forms.Button but_dodOcen;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Button but_odsw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_czysc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button11;
    }
}

