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
        public int Id { get; set; }
        public string Haftalar { get; set; }
        public DateTime HaftaBaslangicTarihi { get; set; }
        public DateTime HaftaBitisTarihi { get; set; }



    }
}
