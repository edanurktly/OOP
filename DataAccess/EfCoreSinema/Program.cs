using EfCoreSinema.Contexts;
using EfCoreSinema.Entites.Concrete;

namespace EfCoreSinema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlDbContext dbContext = new SqlDbContext();

            #region Kayit Ekleme
            Kategori kategori = new Kategori()
            {
                KategoriAdi = "Macera",
                Aciklama = "Macera"
            };
            dbContext.Kategoriler.Add(kategori);


            //Film film = new Film()
            //{
            //    FilmAdi="Buz Devri1",
            //    Aciklama="BUZ DEVRİ1",
            //     FilmSuresi=90

            //};
            //dbContext.Filmler.Add(film);
            dbContext.SaveChanges();
            #endregion
            #region Kayit Guncelleme
            //var kategori= dbContext.Kategoriler.FirstOrDefault(p => p.KategoriAdi == "Macera");

            if(kategori != null)
            {
                kategori.Aciklama = "Macera Kategorisi";
            }
            dbContext.SaveChanges();        
            #endregion






            Console.WriteLine("Hello, World!");
        }
    }
}