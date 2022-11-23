using EfCoreSinema.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entites.Concrete
{
    public class Hafta:BaseEntity<Guid>
    {
        public string HaftaAdi { get; set; }
        public DateTime? HaftaBaslangicTarihi { get; set; }
        public DateTime? HaftaBitisTarihi { get; set; }

        public ICollection<Gosterim>? Gösterimler { get; set; }

    }
}
