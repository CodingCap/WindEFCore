using Microsoft.EntityFrameworkCore;
using WindEFCore.Models;

namespace WindEFCore
{
    class WindDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }

        public WindDbContext(DbContextOptions<WindDbContext> options)
            : base(options)
        {
            
        }
    }
}
