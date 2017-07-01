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
    public partial class WyswietlOceny : Form
    {
        public WyswietlOceny(Student s)
        {
            InitializeComponent();
            foreach (Ocena o in s.oceny)
                dataGridView1.Rows.Add(o.nazwa, o.ectsow, o.wartosc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
