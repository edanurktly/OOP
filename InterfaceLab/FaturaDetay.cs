using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    public class FaturaDetay
    {



        public int FaturaDetayId { get; set; }
        public int FaturaNo { get; set; }
        public Urun Urun { get; set; }
        public decimal Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public decimal IndirimOrani { get; set; }

    }
}
