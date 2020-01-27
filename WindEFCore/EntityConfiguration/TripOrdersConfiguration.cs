using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WindEFCore.Models;

namespace WindEFCore.EntityConfiguration
{
    class TripOrdersConfiguration : IEntityTypeConfiguration<TripOrders>
    {
        public void Configure(EntityTypeBuilder<TripOrders> builder)
        {
            builder.HasKey(to => new {to.TripId, to.OrderId});

            builder.HasOne(to => to.Order)
                .WithMany(o => o.TripOrders)
                .HasForeignKey(to => to.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(to => to.Trip)
                .WithMany(t => t.TripOrders)
                .HasForeignKey(to => to.TripId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new TripOrders
                {
                    OrderId = 1,
                    TripId = 1
                },
                new TripOrders
                {
                    OrderId = 1,
                    TripId = 2
                },
                new TripOrders
                {
                    OrderId = 1,
                    TripId = 3
                },
                new TripOrders
                {
                    OrderId = 2,
                    TripId = 1
                },
                new TripOrders
                {
                    OrderId = 3,
                    TripId = 4
                },
                new TripOrders
                {
                    OrderId = 4,
                    TripId = 5
                });
        }
    }
}
