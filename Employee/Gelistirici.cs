using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Gelistirici:Calisan
    {
        public int BitirilenProjeSayisi { get; set; }

        public Gelistirici(string ad, double maas, int bitirilenProjeSayisi) : base(ad, maas)
        {
            BitirilenProjeSayisi = bitirilenProjeSayisi;
        }

        public override double MaasHesapla()
        {
            return base.MaasHesapla() + (BitirilenProjeSayisi * 1000);
        }

        public override void info()
        {
            Console.WriteLine($"{Ad} adlı geliştiricinin maaşı: {MaasHesapla():C2}");
        }


    }
}
