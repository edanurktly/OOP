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
        public int Id { get; set; }
        public string FilmAdi { get; set; }
        public string Tanimlama { get; set; }
        public DateTime Sure { get; set; }

        public ICollection<Kategori> Kategoriler { get; set; }

    }
}
