using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WindEFCore.Models;

namespace WindEFCore.EntityConfiguration
{
    class AddressConfiguation : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(p => p.Street).IsRequired();

            builder.HasData(
                new Address
                {
                    AddressId = 1,
                    Street = "Theodor Pallady",
                    StreetNumber = "47"
                }, 
                new Address
                {
                    AddressId = 2,
                    Street = "Highway to hell",
                    StreetNumber = "666"
                },
                new Address
                {
                    AddressId = 3,
                    Street = "Ragnarok",
                    StreetNumber = "13"
                });
        }
    }
}
