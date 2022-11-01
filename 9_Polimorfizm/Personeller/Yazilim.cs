using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Personeller
{
    public enum Seviye
    {
        baslangic=1 ,
        orta,
        Usta
    }
    public class Yazilim:BasePersonel
    {
       public Seviye Seviye { get; set; }
        public override double MaasHesapla()
        {
            base.MaasHesapla();

            switch (Seviye)
            {
                case Seviye.baslangic:
                    Maas += Maas * 0.1;
                    break;

                case Seviye.orta:
                    Maas += Maas * 0.2;
                    break;

                case Seviye.Usta:
                    Maas += Maas * 0.5;
                    break;
            }
            return Maas;
        }

    }
}
