using Microsoft.EntityFrameworkCore;
using OrderNameSpace;

namespace DatabaseNameSpace
{
    public class Database : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("server=localhost;database=eforder;user=root;password=");
    }
}