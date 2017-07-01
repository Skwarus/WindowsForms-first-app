using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOLOKWIUM_OKIENKA
{
    public partial class DodajStudenta : Form
    {
        public Student st;
        public DodajStudenta()
        {
            InitializeComponent();
        }
        private void but_reset_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
        }

        private void but_akcept_Click(object sender, EventArgs e)
        {
            try
            {
                st = new Student(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToDateTime(dateTimePicker1.Text));
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Błąd, sprawdz poprawnosc wjebanych danych!");
            }
        }
    }
}
