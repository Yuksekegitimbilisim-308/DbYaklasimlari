using CodeFirstEfProject.Entities;
using System.Data.Entity;

namespace CodeFirstEfProject
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Server = DESKTOP-OBCSS28;Database = RentaCarDb;User Id=sa;Password = 1234;")
        {}
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Car> Cars{ get; set; }
    }
}
