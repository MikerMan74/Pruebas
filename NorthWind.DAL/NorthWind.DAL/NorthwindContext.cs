using Microsoft.EntityFrameworkCore;
using NorthWind.Entities;

namespace NorthWind.DAL
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;database=NorthWind;Trusted_Connection=True;");
        }
    }

}