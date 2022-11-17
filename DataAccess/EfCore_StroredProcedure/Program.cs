using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EfCore_StroredProcedure
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            SqlDbContext dbContext = new SqlDbContext();

            string urunadi = "Peynir";

            //Parametreli Kullanim
            SqlParameter name = new SqlParameter("name", "Peynir");
            name.Direction=System.Data.ParameterDirection.Input;
            name.DbType = System.Data.DbType.String;

            var liste =dbContext.Urunler.FromSql($"Exec UrunleriGetir");

            liste.ToList();

            foreach(var item in liste )
            {
                Console.WriteLine(item.Id+ "" +item.UrunAdi);
            }


            Console.WriteLine("Hello, World!");
        }
    }
}