using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConApp.Entities
{
    public class Sehir
    {
      public int Id { get; set; }
        public string SehirAdi { get; set; }
        public ICollection<ilce> Ilceler { get; set;}
    }
}
