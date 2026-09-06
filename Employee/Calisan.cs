using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Calisan
    {
        public string Ad { get; set; }
        public double Maas { get; set; }

        public Calisan(string ad, double maas)
        {
            Ad = ad;
            Maas = maas;
        }

        public virtual double MaasHesapla()
        {
            return Maas;
        }
        public virtual void info()
        {
            Console.WriteLine($"{Ad} adlı çalışanın maaşı: {MaasHesapla():C2}");
        }
    }
}
