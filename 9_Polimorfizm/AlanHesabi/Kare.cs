using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.AlanHesabi
{
    internal class Kare:AlanVeCevre
    {
        public int Kenar { get; set; }

        public override double Alan()
        {
            return Kenar * Kenar;
        }
        public override double Cevre()
        {
            return 4 * Kenar;
        }

    }
}
