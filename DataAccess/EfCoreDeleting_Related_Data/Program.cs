using Microsoft.EntityFrameworkCore;

namespace EfCoreDeleting_Related_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            SqlDbContext dbContext= new SqlDbContext();

          

                var kategori =dbContext.Kategoriler.Where(p => p.Id == 1).FirstOrDefault();

            dbContext.Kategoriler.Remove(kategori);

            dbContext.SaveChanges();


            Console.WriteLine("Hello, World!");
        }
    }
}