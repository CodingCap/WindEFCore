using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WindEFCore.Models;

namespace WindEFCore.EntityConfiguration
{
    class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder
                .HasOne(c => c.Address)
                .WithOne(a => a.Company)
                .HasForeignKey<Address>(b => b.AddressId);

            builder.HasMany(c => c.Trips)
                .WithOne(t => t.Carrier)
                .HasForeignKey(t => t.CarrierId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder.HasMany(c => c.Orders)
                .WithOne(o => o.Client)
                .HasForeignKey(o => o.ClientId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder.Property(c => c.CompanyName)
                .HasMaxLength(200);

            builder.HasData(
                new Company
                {
                    CompanyId = 1,
                    CompanyName = "WindSoft"
                },
                new Company
                {
                    CompanyId = 2,
                    CompanyName = "Perly Gates"
                },
                new Company
                {
                    CompanyId = 3,
                    CompanyName = "Valhala INC."
                });
        }
    }
}
