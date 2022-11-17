using EfCoreKitaplık.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplık.Context
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Raf> Raflar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Kitaplik.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent Api Uzerinde Yapilirsa Composit Tabloyu kendimiz olusturmamiz gerekir


            //modelBuilder.Entity<KitapYazar>()
            //.HasKey(p => new { p.YazarID, p.KitapId });

            //modelBuilder.Entity<KitapYazar>()
            //   .HasOne(p => p.Kitap)
            //   .WithMany(p => p.Yazarlar)
            //    .HasForeignKey(p => p.KitapId);

            //modelBuilder.Entity<KitapYazar>()
            //  .HasOne(p => p.Yazar)
            //   .WithMany(p => p.Kitaplar)
            //   .HasForeignKey(p =>p.YazarID);


          


            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly()
        }
    }
}
