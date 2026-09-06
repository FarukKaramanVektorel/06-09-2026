using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_09_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teker teker = new Teker("Michelin", 160, 60, 55);
            Teker teker1 = new Teker("Michelin", 160, 60, 55);
            Teker teker2 = new Teker("Michelin", 160, 60, 55);
            Teker teker3 = new Teker("Michelin", 160, 60, 55);
            Motor motor = new Motor("Honda", 1000, "Benzin & LPG");
            TamirHane tamirHane = new TamirHane("Mithat");
            Car arac= new Car("Honda", "Civic", motor, new Teker[] { teker, teker1, teker2, teker3 });

            arac.Calistir();
            arac.TamireGotur(tamirHane);
            arac.Durdur();
            Console.WriteLine(arac.info());
            Console.ReadLine();
        }
    }
}
