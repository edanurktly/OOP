using _9_Polimorfizm.AlanHesabi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Emlak
{
    public class Residance:KonutDaire
    {
        public int Aidat { get; set; }

        public Residance(Kimden kimden, int m2, int bulundugukat, int aidat) : base(kimden, m2, bulundugukat)
        {

        }
        public override double KiraHesapla()
        {
            double kira = base.KiraHesapla();

            kira += Aidat;


            return kira;
        }

    }
}
