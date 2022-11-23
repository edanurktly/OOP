using EfCoreSinema.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entites.Concrete
{
    public class Seans:BaseEntity<Guid>
    {
       public string SeansAdi { get; set; }

        public ICollection<Gosterim>? Gösterimler { get; set; }
    }
}
