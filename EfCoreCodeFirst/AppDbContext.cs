using Microsoft.EntityFrameworkCore;

namespace EfCoreCodeFirst
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-OBCSS28;Database = EfCoreCodeFirstDb;User Id=sa;Password=1234;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}
