using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.AlanHesabi
{
    internal class Dikdortgen:AlanVeCevre
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }
        public override double Alan()
        {
            return KisaKenar * UzunKenar;
        }
        public override double Cevre()
        {
            return (KisaKenar + UzunKenar) * 2;
        }



    }
}
