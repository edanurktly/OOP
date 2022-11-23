using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfreChangeTracker
{
   public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int? Adet { get; set; }

        public float? Fiyat { get; set; }
    }
}
