using EFCoreBahis.Entites.Concrete;
using EFCoreBahis.EntitesTypeConfigurations.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBahis.Contexts
{
    public class SqlDbContext:DbContext
    {
        public DbSet<BahisKonusu> BahisKonuları { get; set; }
        public DbSet<BahisCesit> BahisCesitleri
        { get; set; }

        public DbSet<BahisHareket> BahisHareketleri { get; set; }

        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Oynanan> Oynananlar { get; set; }
        public DbSet<Oynayan> Oynayanlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Bahis;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //300 adet tablo oldugunun düsünürsek burasi sisecek
            //modelBuilder.ApplyConfiguration<Kasa>(new KasaMap());

            //Bu kod mevcut projede IEntityTypeConfiguration InterFace'inden kalitim almis ne kadar class varsa hepsini import ederek configuration'larini yapar

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            
        }

   
        
    }
    
}
