using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Emlak
{
    public enum EmlakTipi
    {
        daire = 1,
        Residance,
        MüsatkilEv,
        Villa,
        CiftlikEvi,
        Kösk,
        Yali,
        YaliDairesi,
        Yazlik

    }
     public enum Kimden
    {
        sahibinden=1,
        Emlakcidan,
        insaatfirmasindan
    }
    public abstract class BaseEmlak
    {
        public DateTime IlanTarihi { get; set; }
        public EmlakTipi EmlakTipi { get; set; }

        private int _m2=50;

        public int M2
        {
            get { return _m2=50; }
            set { _m2= value; }
        }

        public  byte OdaSayisi { get; set; }

        public byte BinaYasi { get; set; }
        public Kimden Kimden { get; set; }
        public bool EsyaliMi{ get; set; }


        private double _kira=2500;

        public double Kira
        {
            get { return _kira=2500; }
            set { _kira = value; }
        }

        public virtual double KiraHesapla()
        {
            int m2 = M2 - _m2;
            //m2 basina 100 Tl fark
            Kira += m2 * 100;

            if (EsyaliMi)
            {
                Kira += 1000;
            }
            return Kira;
        }


            public virtual double KomisyonHesapla()
        {
            double kra = KiraHesapla();
            return Kira * 12 * 0.1;
        }
           
        

       
        
       
       
    }
}
