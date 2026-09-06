using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Yonetici yonetici = new Yonetici("Ahmet", 50000, 20000);
            Gelistirici gelistirici = new Gelistirici("Mehmet", 40000, 5);
            Pazarlamaci pazarlamaci = new Pazarlamaci("Ayşe", 40000, 100000);
            Console.WriteLine("Yönetici bilgileri");
            yonetici.info();
            Console.WriteLine("Geliştirici bilgileri");
            gelistirici.info();
            Console.WriteLine("Pazarlamacı bilgileri");
            pazarlamaci.info();

            Console.ReadLine();
        }
    }
}
