using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_StroredProcedure
{
    public class Urun
    {
        public int Id { get; set; } 
        public string  UrunAdi { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
   

    }
}
