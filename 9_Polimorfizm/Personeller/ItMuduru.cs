using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Personeller
{
    public enum Performans
    {
        zayif=1,
        orta,
        iyi,
        cokiyi
    }
    public class ItMuduru:Yazilim
    {
        public Performans Performans { get; set; }
        
        public override double MaasHesapla()
        {
           base.MaasHesapla();
            switch (Performans)
            {
                case Performans.zayif:
                    Maas += Maas * (-0.1);
                    break;

                    case Performans.orta:
                    Maas += Maas * 0.1;
                    break;
                case Performans.iyi:
                    Maas += Maas * 0.25;
                    break;
                case Performans.cokiyi:
                    Maas += Maas * 0.5;
                    break;
                    default:
                    break;
            }
            return Maas;
        }


    }
}
