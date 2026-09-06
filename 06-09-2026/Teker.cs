using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_09_2026
{
    internal class Teker
    {
        public string Marka { get; set; }
        public int Cap { get; set; }
        public int Genisik { get; set; }
        public int Derinlik { get; set; }
        //160/60/55
        public Teker(string marka, int cap, int genisik, int derinlik)
        {
            Marka = marka;
            Cap = cap;
            Genisik = genisik;
            Derinlik = derinlik;
        }

        public string info()
        {
            return $"Marka: {Marka}, Ebat: {Cap}/{Genisik}/{Derinlik}\n";
        }
    }
}
