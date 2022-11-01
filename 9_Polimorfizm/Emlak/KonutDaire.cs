using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Emlak
{
    public class KonutDaire:BaseEmlak
    {
        public bool SiteIcerisindemi { get; set; }
        public byte KacinciKat { get; set; }

        public KonutDaire(Kimden kimden, int m2, int KacinciKat) : base(kimden, m2)
        {

        }
        public override double KiraHesapla()
        {
            double kira =base.KiraHesapla();
            if(SiteIcerisindemi)
            {
                kira += 2000;
            }
            if(KacinciKat > 0)
            {
                kira += 500;
            }
            return kira;
        }
    }
}
