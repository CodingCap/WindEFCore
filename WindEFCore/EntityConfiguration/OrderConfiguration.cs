using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WindEFCore.Models;

namespace WindEFCore.EntityConfiguration
{
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(p => p.Price)
                .HasColumnType("DECIMAL(9,2)");

            builder
                .HasOne(o => o.Client)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.ClientId);

            builder
                .HasData(
                    new Order
                    {
                        OrderId = 1,
                        Currency = Currency.EUR,
                        Price = 10,
                        ReferenceNumber = "test1",
                        ClientId = 1
                    },
                    new Order
                    {
                        OrderId = 2,
                        Currency = Currency.RON,
                        Price = 20,
                        ReferenceNumber = "test2",
                        ClientId = 1
                    },
                    new Order
                    {
                        OrderId = 3,
                        Currency = Currency.RON,
                        Price = 30,
                        ReferenceNumber = "test3",
                        ClientId = 1
                    },
                    new Order
                    {
                        OrderId = 4,
                        Currency = Currency.USD,
                        Price = 40,
                        ReferenceNumber = "test4",
                        ClientId = 1
                    });
        }
    }
}
