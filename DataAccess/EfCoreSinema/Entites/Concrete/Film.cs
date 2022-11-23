using EfCoreSinema.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entites.Concrete
{
    public class Film:BaseEntity<Guid>
    {
       
        public string FilmAdi { get; set; }
        public string? Aciklama { get; set; }
        public short? FilmSuresi { get; set; }

        public ICollection<Kategori>? Kategoriler { get; set; }

        public ICollection<Gosterim>? Gösterimler { get; set; }

    }
}
