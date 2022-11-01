using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.AlanHesabi
{
    internal class Daire:AlanVeCevre
    {
        public int YariCap { get; set; }

        public override double Alan()
        {
            return Math.PI * Math.Pow(YariCap, 2);
        }

        public override double Cevre()
        {
            return Math.PI * 2 * YariCap;
        }
    }
}
