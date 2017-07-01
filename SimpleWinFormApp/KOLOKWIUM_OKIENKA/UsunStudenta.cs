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
    public partial class UsunStudenta : Form
    {
        //zmiana


        public string nazw;


        public UsunStudenta()
        {
            InitializeComponent();
        }

        private void but_usun_Click(object sender, EventArgs e)
        {
            try
            {
                nazw = textBox1.Text;
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd!");
            }
        }
    }
}
