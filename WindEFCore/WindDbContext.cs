using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
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
        //public DbSet<ClientOrdersCount> ClientOrdersCounts { get; set; }
        
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

            modelBuilder.Entity<Order>().Property<DateTime>("LastUpdated")
                .HasDefaultValue(new DateTime(1900, 1, 1));

            modelBuilder.Entity<Company>().Property<DateTime>("LastUpdated")
                .HasDefaultValue(new DateTime(1900, 1, 1));

            modelBuilder.Entity<Company>().Property<byte[]>("RowVersion")
                .IsRowVersion();


            modelBuilder.Entity<ClientOrdersCount>(co =>
            {
                co.HasNoKey();
                co.ToView("dbo.niet");
                co.Property(p => p.ClientName).HasColumnName("CompanyName");
                co.Property(p => p.Count).HasColumnName("Cnt");
            });


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseLazyLoadingProxies()
                .UseSqlServer(GetConnectionString());
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries())
            {
                if((entry.State == EntityState.Added || entry.State == EntityState.Modified) && entry.Metadata.FindProperty("LastUpdated") != null)
                {
                    entry.Property("LastUpdated").CurrentValue = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
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
