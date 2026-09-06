using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Pazarlamaci: Calisan
    {
        public double SatisMiktari { get; set; }

        public Pazarlamaci(string ad, double maas, double satismiktari) : base(ad, maas)
        {
            SatisMiktari = satismiktari;
        }

        public override double MaasHesapla()
        {
            return base.MaasHesapla() + (SatisMiktari * 0.05);
        }

        public override void info()
        {
            Console.WriteLine($"{Ad} adlı pazarlamacının maaşı: {MaasHesapla():C2}");
        }
    }
}
