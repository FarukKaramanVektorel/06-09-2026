using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_09_2026
{
    internal class Yemek
    {
        public string Name { get; set; }
        public bool IsVegeterian { get; set; }

        public Yemek(string name, bool isVegeterian)
        {
            Name = name;
            IsVegeterian = isVegeterian;
        }

       public string info()
        {
            return $"Yemek Adı: {Name}, Vejetaryen mi?: {IsVegeterian}";
        }
    }
}
