using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLOKWIUM_OKIENKA
{
    public class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int index { get; set; }
        public DateTime dataUrodzenia { get; set; }
        public List<Ocena> oceny = new List<Ocena>();

        public Student(string imie,string nazwisko,int index,DateTime?dataUrodzenia=null)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.index = index;
            this.dataUrodzenia = dataUrodzenia != null ? (DateTime)dataUrodzenia : DateTime.Now;
        }
        public Student() : this("", "", 0, null) { }
    }
}
