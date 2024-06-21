using Microsoft.EntityFrameworkCore;

namespace trimandstyle.com.AppDbContext
{
    public class TrimAndStyleDbContext:DbContext
    {
        public TrimAndStyleDbContext(DbContextOptions<TrimAndStyleDbContext> options)
            : base (options) 
        { 

        }
    }
}
