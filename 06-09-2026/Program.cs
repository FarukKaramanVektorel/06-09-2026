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
            Human mahmut = new Human(80, 175, new DateTime(2000, 10, 15), "Keser", "Mustafa");

            mahmut.Weight = -85;
            Console.WriteLine(mahmut.info());


            Console.ReadLine();
        }
    }
}
