using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WindEFCore.Models;

namespace WindEFCore.EntityConfiguration
{
    class TripConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasData(
                new Trip
                {
                    TripId = 1,
                    Price = 10,
                    Currency = Currency.RON,
                    TripReference = "tesd1",
                    CarrierId = 1
                },
                new Trip
                {
                    TripId = 2,
                    Price = 20,
                    Currency = Currency.RON,
                    TripReference = "tesd1",
                    CarrierId = 1
                },
                new Trip
                {
                    TripId = 3,
                    Price = 30,
                    Currency = Currency.RON,
                    TripReference = "tesd1",
                    CarrierId = 1
                },
                new Trip
                {
                    TripId = 4,
                    Price = 40,
                    Currency = Currency.RON,
                    TripReference = "tesd1",
                    CarrierId = 1
                },
                new Trip
                {
                    TripId = 5,
                    Price = 50,
                    Currency = Currency.RON,
                    TripReference = "tesd1",
                    CarrierId = 1
                });
        }
    }
}
