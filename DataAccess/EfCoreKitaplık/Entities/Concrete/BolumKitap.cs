using EfCoreKitaplık.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplık.Entities.Concrete
{
    public class BolumKitap
    {
        public Guid BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public Guid KitapID { get; set; }
        public Kitap Kitap { get; set; }
    }
}
