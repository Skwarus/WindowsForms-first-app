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
    public partial class Szukaj : Form
    {
        List<Student> stud;
        public Szukaj(List<Student> s)
        {
            stud = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Szukaj
        {
            try
            {
                Student pom = stud.Find(b => b.nazwisko == textBox1.Text);
                int zmienna = 0;
                int licznik = 0;
                foreach (Student s in stud)
                {
                    if (s == pom)
                        zmienna = licznik;
                    licznik++;
                }
                if (stud.Contains(pom))
                {
                    grid.Rows.Add(pom.imie, pom.nazwisko, pom.index, pom.dataUrodzenia, zmienna);
                    MessageBox.Show("Znaleziono w bazie podanego studenciaka!");
                }
                else
                {
                    MessageBox.Show("Nie ma takiego studenciaka w bazie!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("blad: " + ex.Message);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
