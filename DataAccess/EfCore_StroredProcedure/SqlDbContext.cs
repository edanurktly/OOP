using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_StroredProcedure
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Urun> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)/mssqllocaldb,Database=TestdB;Trusted_conection=true");
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*DeleteBehavior.Cascade:Yapilirsa esas tablodan veri silinirse bagimli tablodakiler de silinir.
             * DeleteBehavior.NoAction:Bu durumda bagimli tabloda herhangi bir islem yapma
             * DeleteBehavior.Restrct:Bu durumda bagimli tabloda herhangi bir islem yapma
             * DeletedBehvior.SetNull:Bu durumda ,se bagimli tabloda verilere null degeri atacaktır
         
             */
            modelBuilder.Entity<Urun>()
                .HasOne(p => p.Kategori)
                .WithMany(p => p.Urunler)
                .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<Kategori>()
                .HasData(new Kategori { Id= 1, KategoriAdi="Yiyecek" },
                new Kategori { Id=2, KategoriAdi="icecek"});

            modelBuilder.Entity<Urun>()
                .HasData(new Urun { Id = 1, UrunAdi="Peynir", KategoriId=1 },
                new Urun { Id = 2, UrunAdi = "Ekmak", KategoriId = 1 },
                new Urun { Id = 3, UrunAdi = "Kavun", KategoriId = 1 },
                new Urun { Id = 4, UrunAdi = "Karpuz", KategoriId = 1 });
        }

    }
}
