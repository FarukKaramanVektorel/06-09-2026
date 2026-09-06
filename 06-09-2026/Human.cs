using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_09_2026
{
    internal class Human
    {
		private string _name;
		private string _lastName;
		private DateTime _birthDay;
		private double _height;
		private double _weight;

        public Human(double weight, double height, DateTime birthDay, string lastName, string name)
        {
            Weight = weight;
            Height = height;
            BirthDay = birthDay;
            LastName = lastName;
            Name = name;
        }

        public Human()
        {
            Console.WriteLine("Human sınıfı ayağa kalktı");
        }

        public double Weight
		{
			get { return _weight; }
			set { 
			if(value < 0)
				{
                    Console.WriteLine("Yok daha neler...");
				}
				else
				{
					_weight = value;
				}
			}
		}


		public double Height
		{
			get { return _height; }
			set {
                if (value < 0)
                {
                    Console.WriteLine("Yok daha neler...");
                }
                else
                {
                    _height = value;
                }
            }
		}


		public DateTime BirthDay
		{
			get { return _birthDay; }
			set { _birthDay = value; }
		}


		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}


		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string info()
		{
			return $"Ad: {Name+" "+LastName}, Doğum Tarihi: {BirthDay} Boy: {Height} Kilo: {Weight}";
		}

	}
}
