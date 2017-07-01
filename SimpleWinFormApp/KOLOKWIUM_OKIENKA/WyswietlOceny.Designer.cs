namespace KOLOKWIUM_OKIENKA
{
    partial class WyswietlOceny
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.przedmiot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ectsow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.przedmiot,
            this.ectsow,
            this.wartosc});
            this.dataGridView1.Location = new System.Drawing.Point(33, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // przedmiot
            // 
            this.przedmiot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.przedmiot.HeaderText = "Przedmiot";
            this.przedmiot.Name = "przedmiot";
            // 
            // ectsow
            // 
            this.ectsow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ectsow.HeaderText = "Ilosc Ectsow";
            this.ectsow.Name = "ectsow";
            // 
            // wartosc
            // 
            this.wartosc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wartosc.HeaderText = "Wartosc";
            this.wartosc.Name = "wartosc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "zamknij okno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WyswietlOceny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WyswietlOceny";
            this.Text = "WyswietlOceny";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn przedmiot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ectsow;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartosc;
        private System.Windows.Forms.Button button1;
    }
}