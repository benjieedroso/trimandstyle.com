using Microsoft.EntityFrameworkCore;
using trimandstyle.com.Models;

namespace trimandstyle.com.AppDbContext
{
    public class TrimAndStyleDbContext:DbContext
    {
        public TrimAndStyleDbContext(DbContextOptions<TrimAndStyleDbContext> options)
            : base (options) 
        { 

        }

        public DbSet<Barber> Barbers { get; set; }
        public DbSet<Customer> Customers{ get; set; }

    }
}
