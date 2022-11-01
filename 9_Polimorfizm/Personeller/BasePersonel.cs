using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Personeller
{
    public enum EgitimDurumu
    {
        lise=1,
        Universite,
        yükseklisans,
        doktora
    }

    
    public  abstract  class BasePersonel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
     
        public  EgitimDurumu EgitimDurumu{ get; set; }
        public int cocuksayisi { get; set; }

        private  double _Maas=5000;

        public double Maas
        {
            get { return _Maas; }
            set { _Maas = value; }
        }
        public virtual double MaasHesapla()
        {
            if (cocuksayisi > 0)
            {
                Maas += cocuksayisi * 100;
            }

            switch (EgitimDurumu)
            {
                case EgitimDurumu.lise:
                    break;
                case EgitimDurumu.Universite:
                    Maas += Maas * 0.2;
                    break;
                case EgitimDurumu.yükseklisans:
                    Maas += Maas * 0.3;

                    break;
                case EgitimDurumu.doktora:
                    Maas += Maas * 0.4;

                    break;
                default:
                    break;
            }

            return Maas;
        }

    }
}
