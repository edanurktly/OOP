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
        public int Id { get; set; }
        public int FilmID { get; set; }
        public Film Filmler { get; set; }
        public int SalonID { get; set; }
        public Salon Salonlar{ get; set; }
        public int HaftaID { get; set; }
        public Hafta Haftalar { get; set; }
        public int  SeansID { get; set; }
        public  Seans Seanslar { get; set; }
    }
}
