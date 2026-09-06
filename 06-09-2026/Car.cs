using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_09_2026
{
    internal class Car : Tasit// is a
    {
        public string Marka { get; }
        public string Model { get; }
        public Motor Motor { get; set; }// has a
        public Teker[] Tekerler { get; set; } // has a

        public Car(string marka, string model, Motor motor, Teker[] tekerler)
        {
            Marka = marka;
            Model = model;
            Motor = motor;
            Tekerler = tekerler;
        }

        public void TekerDegis(Teker teker)// uses a
        {
            Console.WriteLine($"{teker} değiştirildi...");
        }

        public void TamireGotur(TamirHane tamirci)// uses a
        {
            tamirci.TamirEt();
        }

        public string info()
        {
            return $"Marka: {Marka}, Model: {Model},\nMotor: {Motor.info()},\nTekerler: {string.Join(", ", Tekerler.Select(t => t.info()))}";
        }
    }
}
