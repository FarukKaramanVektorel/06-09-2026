using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_09_2026
{
    internal sealed class Student: Human // Human Base Class - Student Derived Class
    {//student sınıfı sealed olarak işaretlendi, bu nedenle artık başka bir sınıf Student sınıfından türetilemez.
        public bool isVegeterian { get; set; }
        public Pencil Pencil { get; set; }
        public Bag Bag { get; set; }

        public Student(double weight, double height, DateTime birthDay, string lastName, string name,bool isVegeterian, Pencil pencil, Bag bag) : base(weight, height, birthDay, lastName, name)
        {
            Pencil = pencil;
            Bag = bag;
            this.isVegeterian = isVegeterian;
        }

        public sealed override void nefesAl()// bu metod artık daha fazla override edilemez
        {

        }

        public override void yemekYe(Yemek yemek)
        {
            base.yemekYe(yemek);

            if(!yemek.IsVegeterian && isVegeterian)
            {
                Console.WriteLine("Ben vejetaryenim, bu yemeği yiyemem.");
                return;
            }
            Console.WriteLine($"{yemek.info()} Yemek yiyorum...");
        }
        public void Odev_Yazdir(Printer printer)
        {
            printer.Print("Ödev yazdırılıyor...");
        }
    }
}
