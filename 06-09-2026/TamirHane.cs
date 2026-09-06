using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_09_2026
{
    internal class TamirHane
    {
        public string Name { get; set; }

        public TamirHane(string name)
        {
            Name = name;
        }

        public void TamirEt()
        {
            Console.WriteLine($"{Name} usta aracı tamir ediyor...");
        }
    }
}
