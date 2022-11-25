using Microsoft.EntityFrameworkCore;

namespace EfCore_RelatedDataSave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext context = new SqlDbContext();

            #region one-to-one iliskilerde object referansi ile kayit ekleme

            //dEPENDET oBJENİN OLUSTURULMASİ
            Address alininAdresi = new Address
            {
                Ulke="TR",
                Sehir="VAN",
                Ilce="TATVAN"
            };
          


            //PRİNCİPAL OBJENİN OLUSTURULMASİ
            Person Ali = new Person
            {
                Adi= "Ali",
                Soyadi = "Yilmaz",
                Address= alininAdresi
            };

             context.Personeller.Add(Ali);
            context.SaveChanges();

            #endregion
            #region one- to- one iliskilerde object initilaze ile kayit ekleme

            //Person Ayse = new Person { Adi = "Ayse",
            //    Soyadi="Kaya",
            //    Address= new Address
            //    {
            //        Ulke="TR",
            //        Sehir="MUS",
            //        Ilce="Adilcevaz"
            //    }
            //};

            #region Depented entit direk olarak database'e saklanamaz.
            //Depented entit direk olarak database'e saklanamaz.Asagidaki kod hata vericektir.

            //var adres = new Address
            //{
            //    Ulke = "TR",
            //    Sehir = "MUS",
            //    Ilce = "Adilcevaz"
            //};


            //context.Addresses.Add(adres);
            //context.SaveChanges(); 
            #endregion

            #endregion
            #region one-to-Many iliskilerde Kayit islemi 
            #region 1.Yontem: Principal Entity uzerinden Dependent Entity verisi ekleme 

            #region Nesne Referansi uzerinden Ekleme

            //Blog blog = new Blog { Name = "Dunya kupasi maclari" };

            //blog.Posts.Add(new Post { Baslik="almanya japonya maci", Aciklama="hic beklenmiyordu"});

            //blog.Posts.Add(new Post { Baslik = "almanya japonya maci", Aciklama = "japonlar imkansizi basardi" });

            //blog.Posts.Add(new Post { Baslik = "almanya japonya maci", Aciklama = "japonlar mac sonrasi kendi coplerini  topladi" });

            //context.Bloglar.Add(blog);
            //context.SaveChanges();

            #endregion
            #region Object Initializer uzerinden ekleme

            //Blog blog = new Blog
            //{
            //    Name="Blog Yazisi 2",
            //    Posts=new List<Post>
            //    {
            //        new Post {Baslik="blog 2 yorum 1", Aciklama="yorum1"},
            //        new Post {Baslik="blog 2 yorum 2", Aciklama="yorum2"},
            //        new Post {Baslik="blog 2 yorum 3", Aciklama="yorum3"}
            //    }
            //};
            #endregion
            #endregion

            #region 2.yontem dependent entity uzerinden kayit ekleme

            //Post post = new Post()
            //{
            //    Baslik="blog 3 yorum 1",
            //    Aciklama="Blog 3 icin yorum eklendi",
            //    Blog = new() { Name="blog 3"}
            //};

            //context.Postlar.Add(post);
            //context.SaveChanges();

            #endregion
            #region 3.yontem foreign key üzerinden veri ekleme

            //Post post = new Post()
            //{
            //    Baslik="Yorum2",
            //    Aciklama="blog 3 icin yorum",
            //    BlogId=3
            //};
            //context.Postlar.Add(post);
            //context.SaveChanges();

            #endregion
            #endregion
            #region Many-to-many kayit ekleme

            //Kitap yuksekMatematik = new Kitap()
            //{
            //    KitapAdi = "YÜKSEK MATEMATİK",
            //    Yazarlar = new HashSet<Yazar>()
            //    {
            //        new Yazar (){ YazarAdi = "Ahmet Karadeniz" },
            //        new Yazar (){ YazarAdi =" Mehmet Karadeniz" }
            //    }
            //};
            //context.Kitaplar.Add(yuksekMatematik);
            //context.SaveChanges();



            //Yazar AliVeli = new Yazar()
            //{
            //   YazarAdi = "Ali veli",
            //   Kitaplar= new HashSet<Kitap>()
            //    {
            //        new Kitap(){KitapAdi="Cin alinin maceralari"},
            //         new Kitap(){KitapAdi="Cin ali tatilde"}
            //   }
            //};
            //context.Yazarlar.Add(AliVeli);
            //context.SaveChanges();





            #endregion

            #region Many-to-Many Kayit Güncelleme
            //6 numarali kitabin 1 numarali yazara atamak istedigimizde

            ////Kitaba Konumlan
            //Kitap? kitap = context.Kitaplar.Find(6);
            ////Yeni Yazara Konumlan
            //Yazar? yeniyazar= context.Yazarlar.Find(1);

            ////Eski Yazara Konumaln
            //Yazar? eskiyazar = context.Yazarlar
            //    .Include(p => p.Kitaplar)
            //    .FirstOrDefault(p => p.Id == 6);

            ////Eski Yazardan Kitabı kaldır
            //eskiyazar.Kitaplar.Remove(kitap);

            ////Kitabı yeni yazara ekle
            //kitap.Yazarlar.Add(yeniyazar);

            //var objects= context.ChangeTracker;

            //context.SaveChanges();
            #endregion

            #region One-to-Many Kayit Guncelleme
            //blog 3 icin yapilan en son yorum'u blog 2 ye aktarin.

            /*
              1-Eski Blog'a konumlan
            2-Post'a konumlan
            3- Eski Blogdan Remove Et
            4- Yeni Bloga konumlan
            5-Yeni Bloga Ekle
             */

            //1-Eski Bloga konumlan 
            //Blog? eskiBlog=context.Bloglar.Include(p=>p.Posts).FirstOrDefault(p=>p.Id==3);

            ////2-Post'a Konumlan
            //Post? post=context.Postlar.FirstOrDefault(p=>p.Id==9);

            ////3.Adim
            //eskiBlog.Posts.Remove(post);

            ////4-Adim
            //Blog? yeniBlog = context.Bloglar.Find(2);
            //yeniBlog.Posts.Add(post);

            //context.SaveChanges();






            #endregion
            #region Bagimli verilerin iliskisel ana veriyi guncelleme

            //Dependent Entity'nin Principal Entitiy'sini Guncelleme
            //6 numarali post'u 3 numarali Blog'a atama islemi

            //Post? post = context.Postlar.Find(6);
            //Blog? blog=context.Bloglar.Find(3);

            //post.Blog = blog;

            //context.SaveChanges();

            #endregion

            #region One-To-Many Kayit Silme 
            //3 Numarali blog'a ait postlari silme

            Blog? blog = context.Bloglar.Include(p => p.Posts).FirstOrDefault(p => p.Id == 2);

            context.Bloglar.Remove(blog);

            context.SaveChanges();

            

            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}