using EFCoreBahis.Entites.Abstract;

namespace EFCoreBahis.Entites.Concrete
{
    public class BahisCesit:BaseEntity
    {
        public string Aciklama { get; set; }
        // Bahis konusu ile bire cok iliskilidir
        public int BahisKonusuId { get; set; }
        public BahisKonusu BahisKonusu { get; set; }

       



    }
}