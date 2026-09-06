using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_09_2026
{
    internal class Car
    {
		private int _vitesSayisi;
        public int MyProperty { get; set; }

        public int VitesSayisi
		{
			get { return _vitesSayisi; }
			set { if (value > 0 && value < 8)
				{
					_vitesSayisi = value;
				}
				else
				{
                    Console.WriteLine("Bu kadarda olmaz...");
				}
				}
		}

	}
}
