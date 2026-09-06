using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Yonetici : Calisan
    {
        public double Bonus { get; set; }

        public Yonetici(string ad, double maas, double bonus) : base(ad, maas)
        {
            Bonus = bonus;
        }

        public override double MaasHesapla()
        {
            return base.MaasHesapla() + Bonus;
        }
        public override void info()
        {
            Console.WriteLine($"{Ad} adlı yöneticinin maaşı: {MaasHesapla():C2}");
        }
    }
}
