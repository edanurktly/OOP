using EFCoreBahis.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBahis.Entites.Concrete
{
    public class BahisHareket:BaseEntity
    {
        public int BahisCesitDetayId { get; set; }
        public BahisCesit BahisCesitDetay { get; set; }

        public int OynayanId { get; set; }
        public Oynayan Oynayan { get; set; }
        public double OynananTutar { get; set; }

    }
}
