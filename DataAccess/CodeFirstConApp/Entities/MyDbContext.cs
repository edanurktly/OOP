using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConApp.Entities
{
    public class MyDbContext:DbContext
    {
        //Databaseye aktarılacak tablolar DbSet prop icerisinde bildirilmelidir.

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Product> Urunler { get; set; }
        //burada ise hangi server üzerinde calisacağını belirliyoruz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\Mssqllocaldb;Database=FirstDb;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent Api ile Configurasyon

            #region ToTable


            modelBuilder.Entity<Personel>().ToTable("Personeller");
            #endregion

            #region Column
            modelBuilder.Entity<Personel>()
                .Property(p => p.Email)
                .HasMaxLength(100)
                .HasColumnName("Email");

            
            modelBuilder.Entity<Personel>()
                .Property(p =>p.FirstName)
                .HasMaxLength(50)
                .HasColumnName("Adi")
                .HasColumnOrder(3)
                .HasDefaultValue(" ");

            modelBuilder.Entity<Personel>()
                .Property(p => p.LastName)
                .HasMaxLength(50)
                 .HasColumnName("Soyadi")
                .HasColumnOrder(4)
                .HasDefaultValue(" "); ;

            modelBuilder.Entity<Personel>()
                .Property(p => p.Phone)
                .HasMaxLength(20)
                .HasDefaultValue(" ");

            #endregion

            #region Sehir Ayarlari

            //eger primary key kendimiz yapmak istersek Haskey metodunu kullanırız
            modelBuilder.Entity<Sehir>().HasKey(p => p.Id);

            //Sehir adina göre Uniqe index olusturma
            #region Sehir Tanimlamalari
            modelBuilder.Entity<Sehir>()
                   .HasIndex(p => p.SehirAdi)
                   .IsUnique();

            modelBuilder.Entity<Sehir>()
                .Property(p => p.SehirAdi)
                .HasMaxLength(50);

            //foreingkey 
            modelBuilder.Entity<Sehir>()
                .HasMany(p => p.Ilceler)
                .WithOne(p => p.Sehir)
                .HasForeignKey(p => p.SehirId);

            #endregion

            #region sEHİRLER TABLOSUNU KAYİT EKLEME

            modelBuilder.Entity<Sehir>()
                .HasData(
                new Sehir() { Id = 1, SehirAdi = "Adana" },
                new Sehir() { Id = 2, SehirAdi = "Adiyaman" },
                new Sehir()
                {
                    Id = 3,
                    SehirAdi = "Afyon"
                },
                    new Sehir() { Id = 4, SehirAdi = "Agri" },
                       new Sehir() { Id = 5, SehirAdi = "Amasya" });

            #endregion

            #region Ilce Tanimlamalari
            modelBuilder.Entity<ilce>().HasKey(p => p.Id);
            modelBuilder.Entity<ilce>()
                .Property(p => p.IlceAdi)
                .HasMaxLength(50); 
            #endregion



            #endregion
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
