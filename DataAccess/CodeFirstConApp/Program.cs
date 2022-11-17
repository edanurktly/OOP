using CodeFirstConApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDbContext context = new MyDbContext();


            context.Database.MigrateAsync();
            Console.WriteLine("Hello, World!");
        }
    }
}