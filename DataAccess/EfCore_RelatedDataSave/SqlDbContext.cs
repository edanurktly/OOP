using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_RelatedDataSave
{
    public class SqlDbContext:DbContext

    {
        public DbSet<Person> Personeller { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Bloglar{ get; set; }
        public DbSet<Post> Postlar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blog;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasOne(p => p.Person)
                .WithOne(a => a.Address)
                .HasForeignKey<Address>(p => p.Id);


            base.OnModelCreating(modelBuilder); 
        }
    }
}
