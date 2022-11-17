using EfCoreKitaplık.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplık.Entities.Concrete
{
    public class Raf:BaseEntity<Guid>
    {
        public int RafNo { get; set; }

        public ICollection<Kitap>? Kitaplar{ get; set; }
        
            public Guid? BolumId { get; set; }
        public Bolum? Bolumler { get; set;}




    }
}
