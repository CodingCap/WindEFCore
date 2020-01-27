using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WindEFCore.EntityConfiguration;
using WindEFCore.Models;

namespace WindEFCore
{
    class WindDbContext : DbContext
    {
        private static string _connectionString;

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Trip> Trips { get; set; }
        
        //public WindDbContext(DbContextOptions<WindDbContext> options)
        //    : base(options)
        //{
            
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguation());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new TripOrdersConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new TripConfiguration());
            //modelBuilder.ApplyConfiguration(new tripc)

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(GetConnectionString());
        }

        private static string GetConnectionString()
        {
            if (!string.IsNullOrEmpty(_connectionString))
                return _connectionString;

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            _connectionString = configuration.GetConnectionString("WindDbContext");

            return _connectionString;
        }
    }
}
