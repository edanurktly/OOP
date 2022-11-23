using EfCoreSinema.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entites.Concrete
{
    public class Gosterim:BaseEntity<Guid>
    {
        public Guid? FilmID { get; set; } 
        public Film? Filmler { get; set; }
        public Guid? SalonID { get; set; }
        public Salon? Salonlar{ get; set; }
        public Guid? HaftaID { get; set; }
        public Hafta? Haftalar { get; set; }
        public Guid?  SeansID { get; set; }
        public  Seans? Seanslar { get; set; }
    }
}
