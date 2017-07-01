using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLOKWIUM_OKIENKA
{
    public class Ocena
    {
        public string nazwa { get; set; }
        public int ectsow { get; set; }
        public double wartosc { get; set; }

        public Ocena(string nazwa,int ectsow,double wartosc)
        {
            this.nazwa = nazwa;
            this.ectsow = ectsow;
            this.wartosc = wartosc;
        }
        public Ocena() : this("", 0, 3) { }
    }
}
