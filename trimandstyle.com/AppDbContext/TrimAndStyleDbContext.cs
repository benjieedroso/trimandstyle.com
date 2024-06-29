using Microsoft.EntityFrameworkCore;
using trimandstyle.com.Models;

namespace trimandstyle.com.AppDbContext
{
    public class TrimAndStyleDbContext:DbContext
    {
        //public TrimAndStyleDbContext(DbContextOptions<TrimAndStyleDbContext> options)
        //    : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EPO8RMR\\SQLEXPRESS;database=trimandstyle;user id=tas2024;password=tas2024!;Integrated Security=SSPI; Trust Server Certificate=true;");
        }

        public DbSet<Barber> Barbers { get; set; }
        public DbSet<Customer> Customers{ get; set; }

        public DbSet<Booking> Booking { get; set; }


    }
}
