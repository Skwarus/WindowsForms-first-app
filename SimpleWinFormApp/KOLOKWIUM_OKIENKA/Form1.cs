using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KOLOKWIUM_OKIENKA
{
    [Serializable, XmlRoot("Form1"),XmlType("Form1")]
    public partial class Form1 : Form
    {
        public List<Student> studenci = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            foreach (Student s in studenci)
            {
                grid1.Rows.Add(s.imie, s.nazwisko, s.index, s.dataUrodzenia);
            }
        }
        public void odswiez() //odswiezanie
        {
            grid1.Rows.Clear();
            foreach(Student s in studenci)
            {
                grid1.Rows.Add(s.imie, s.nazwisko, s.index, s.dataUrodzenia);
            }
        }

        private void but_odsw_Click(object sender, EventArgs e) //oswiez
        {
            odswiez();
        }

        private void but_czysc_Click(object sender, EventArgs e) // wyczysc
        {
            studenci.Clear();
            odswiez();
        }

        private void button1_Click(object sender, EventArgs e)//dodaj studenta
        {
            var dialog = new DodajStudenta();
            if (dialog.ShowDialog() == DialogResult.OK)
                studenci.Add(dialog.st);
            odswiez();
        }

        private void but_usu_Click(object sender, EventArgs e)
        {
            var dialog = new UsunStudenta();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                var pom = studenci.Find(s => s.nazwisko == dialog.nazw);
                if (!studenci.Remove(pom))
                    MessageBox.Show("Nie znaleziono studenciaka o takim nazwisku !");
                odswiez();
            }
        }

        private void button2_Click(object sender, EventArgs e) //usuwanie po gridzie
        {
            if (grid1.SelectedRows.Count == 0)
                return;
            int i = grid1.SelectedRows[0].Index;
            studenci.RemoveAt(i);
            odswiez();
        }

        private void but_dodOcen_Click(object sender, EventArgs e) // dodawanie ocen po gridize
        {
            if (grid1.SelectedRows.Count == 0)
                return;
            var dialog = new DodajOcene();
            int i = grid1.SelectedRows[0].Index;
            if (dialog.ShowDialog() == DialogResult.OK && grid1.SelectedRows[0]!=null)
                studenci[i].oceny.Add(dialog.oc);
            odswiez();
        }

        private void But_szuakaj_Click(object sender, EventArgs e)
        {
            var dialog = new Szukaj(studenci);
            if (dialog.ShowDialog() == DialogResult.OK)
                odswiez();
        }

        private void button3_Click(object sender, EventArgs e) //wyswietl oceny
        {
            if (grid1.SelectedRows.Count == 0)
                return;

            var dialog = new WyswietlOceny(studenci[grid1.SelectedRows[0].Index]);
            int i = grid1.SelectedRows[0].Index;

            //if (dialog.ShowDialog() == DialogResult.OK)
            dialog.ShowDialog();
                odswiez();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void button5_Click(object sender, EventArgs e)//save to file
        {
            FileStream fs = new FileStream("./studenci.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach(Student s in studenci)
            {
                sw.WriteLine("[STUDENT]");
                sw.WriteLine(s.imie);
                sw.WriteLine(s.nazwisko);
                sw.WriteLine(Convert.ToString(s.index));
                sw.WriteLine(Convert.ToString(s.dataUrodzenia));
                if(s.oceny.Count>0)
                {
                    sw.WriteLine("[OCENY]");
                    foreach(Ocena o in s.oceny)
                    {
                        sw.WriteLine(o.nazwa);
                        sw.WriteLine(o.ectsow);
                        sw.WriteLine(o.wartosc);
                    }
                }
                sw.WriteLine("[END_STUDENT]");
            }
            sw.Close();
            MessageBox.Show("Save successed !");
        }

        private void button6_Click(object sender, EventArgs e)//read from file
        {

            if(File.Exists("./studenci.txt"))
            {
                grid1.Rows.Clear();
                studenci.Clear();
                FileStream fs = new FileStream("./studenci.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string linia;
                while((linia=sr.ReadLine())!=null)
                {
                    if(linia=="[STUDENT]")
                    {
                        Student s=new Student("","",0,null);
                        s.imie = sr.ReadLine();
                        s.nazwisko = sr.ReadLine();
                        s.index = Convert.ToInt32(sr.ReadLine());
                        s.dataUrodzenia = Convert.ToDateTime(sr.ReadLine());
                        //if((linia=sr.ReadLine())=="[OCENY]")
                        //{
                        //    while()
                        //}
                        if (sr.ReadLine() == "[OCENY]")
                        {
                            while ((linia = sr.ReadLine()) != "[END_STUDENT]")
                            {
                                Ocena o = new Ocena();
                                o.nazwa = linia;
                                o.ectsow = Convert.ToInt32(sr.ReadLine());
                                o.wartosc = Convert.ToDouble(sr.ReadLine());
                                s.oceny.Add(o);
                            }
                        }
                        studenci.Add(s);
                    }
                }
                sr.Close();
                MessageBox.Show("Read successed !");
                odswiez();

            }
        }

        private void button7_Click(object sender, EventArgs e)//serialize
        {
            try
            {
                FileStream fs = new FileStream("./Studenciaki.xml", FileMode.Create);
                StreamWriter sr = new StreamWriter(fs);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                serializer.Serialize(sr, studenci);
                fs.Close();
                MessageBox.Show("Serialize successed !");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Code below doesnt work with deserialize  in button8_click - why?
            /*try
            {
                Stream stream = File.OpenWrite(Environment.CurrentDirectory + "studenciaki.xml");
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Student>)); //must be default constructor in class "Student"
                xmlSer.Serialize(stream, studenci);
                stream.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void button8_Click(object sender, EventArgs e)//deserialize
        {

            if (File.Exists("./studenciaki.xml"))
            {
                try
                {
                    studenci.Clear();
                    //line below doesn work, why?
                    //Stream input = File.OpenRead(Environment.CurrentDirectory + "studenciaki.xml");
                    FileStream input = new FileStream("./studenciaki.xml", FileMode.Open);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                    studenci = (List<Student>)serializer.Deserialize(input);
                    input.Close();
                    MessageBox.Show("Deserialize successed");
                    odswiez();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e) //save to file with SaveFileDialog
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Title = "choose the path";
            ofd.Filter = "*.txt|*.txt";
            try
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {


                    Stream fs = ofd.OpenFile();
                    StreamWriter sw = new StreamWriter(fs);
                    foreach (Student s in studenci)
                    {
                        sw.WriteLine("[STUDENT]");
                        sw.WriteLine(s.imie);
                        sw.WriteLine(s.nazwisko);
                        sw.WriteLine(Convert.ToString(s.index));
                        sw.WriteLine(Convert.ToString(s.dataUrodzenia));
                        if (s.oceny.Count > 0)
                        {
                            sw.WriteLine("[OCENY]");
                            foreach (Ocena o in s.oceny)
                            {
                                sw.WriteLine(o.nazwa);
                                sw.WriteLine(o.ectsow);
                                sw.WriteLine(o.wartosc);
                            }
                        }
                        sw.WriteLine("[END_STUDENT]");
                    }
                    sw.Close();
                    MessageBox.Show("File Saved! ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e) // read data from file with OpenFileDialog
        {
   

                grid1.Rows.Clear();
                studenci.Clear();
                OpenFileDialog dial = new OpenFileDialog();
                if (dial.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(dial.OpenFile());
                    string linia;
                    while ((linia = sr.ReadLine()) != null)
                    {
                        if (linia == "[STUDENT]")
                        {
                            Student s = new Student("", "", 0, null);
                            s.imie = sr.ReadLine();
                            s.nazwisko = sr.ReadLine();
                            s.index = Convert.ToInt32(sr.ReadLine());
                            s.dataUrodzenia = Convert.ToDateTime(sr.ReadLine());
                            if (sr.ReadLine() == "[OCENY]")
                            {
                                while ((linia = sr.ReadLine()) != "[END_STUDENT]")
                                {
                                    Ocena o = new Ocena();
                                    o.nazwa = linia;
                                    o.ectsow = Convert.ToInt32(sr.ReadLine());
                                    o.wartosc = Convert.ToDouble(sr.ReadLine());
                                    s.oceny.Add(o);
                                }
                            }
                            studenci.Add(s);
                        }
                    }
                    sr.Close();
                    odswiez();
                }
       
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
