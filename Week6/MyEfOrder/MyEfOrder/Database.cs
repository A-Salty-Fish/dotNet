using Microsoft.EntityFrameworkCore;

namespace OrderLibrary_EF.Models
{
    public class Database : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("server=localhost;database=eforder;user=root;password=");
    }
}