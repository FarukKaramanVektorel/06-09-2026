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
            //Teker teker = new Teker("Michelin", 160, 60, 55);
            //Teker teker1 = new Teker("Michelin", 160, 60, 55);
            //Teker teker2 = new Teker("Michelin", 160, 60, 55);
            //Teker teker3 = new Teker("Michelin", 160, 60, 55);
            //Motor motor = new Motor("Honda", 1000, "Benzin & LPG");
            //TamirHane tamirHane = new TamirHane("Mithat");
            //Car arac= new Car("Honda", "Civic", motor, new Teker[] { teker, teker1, teker2, teker3 });
            //Console.WriteLine(teker3.info());
            //arac.Calistir();
            //arac.TamireGotur(tamirHane);
            //arac.Durdur();
            //Console.WriteLine(arac.info());

            Yemek yemek = new Yemek("Salata",true);
            Yemek yemek1 = new Yemek("Kebap",false);
            Yemek yemek2 = new Yemek("Çiğ Köfte",true);

            Human human = new Human(45,155,new DateTime(2000,1,5),"Aemdar","Elif");
            human.yemekYe(yemek);
            human.yemekYe(yemek1);
            human.yemekYe(yemek2);

            Student student = new Student(45, 155, new DateTime(2000, 1, 5), "Aemdar", "Elif", true, new Pencil(), new Bag());
            student.yemekYe(yemek);
            student.yemekYe(yemek1);
            student.yemekYe(yemek2);

            Console.ReadLine();
        }
    }
}
