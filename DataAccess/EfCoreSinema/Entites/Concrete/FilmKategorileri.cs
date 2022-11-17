using EfCoreSinema.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entites.Concrete
{
    public class FilmKategorileri:BaseEntity<Guid>
    {
        public Guid FilmID { get; set; }
        public Film Filmler { get; set; }
        public Guid KategoriID { get; set; }
        public Kategori Kategoriler { get; set; }

    }
}
