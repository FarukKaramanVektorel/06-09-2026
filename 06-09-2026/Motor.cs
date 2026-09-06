using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_09_2026
{
    internal class Motor
    {
        public string  Marka { get; set; }
        public int BeygirGucu { get; set; }
        public string Yakit { get; set; }

        public Motor(string marka, int beygirGucu, string yakit)
        {
            Marka = marka;
            BeygirGucu = beygirGucu;
            Yakit = yakit;
        }

        public string info()
        {
            return $"Marka: {Marka}, Beygir Gücü: {BeygirGucu}, Yakıt: {Yakit}";
        }
    }
}
