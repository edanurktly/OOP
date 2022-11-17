using EFCoreBahis.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBahis.Entites.Concrete
{
    public enum KasaHareketTipi:byte
        {
        giris=1,
        cikis
         }
    public class KasaHareket:BaseEntity
    {
        public int KasaId { get; set; }
        public Kasa Kasa { get; set; }

        public int OynayanId { get; set; }
        public Oynayan Oynayan { get; set;}


        public KasaHareketTipi HareketTipi { get; set; }
        public double Tutar { get; set; }

        //foreign key
        public int BahisCesitId { get; set; }
        public BahisCesit BahisCesit { get; set; }
    }
}
