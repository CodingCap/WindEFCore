﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WindEFCore;

namespace WindEFCore.Migrations
{
    [DbContext(typeof(WindDbContext))]
    partial class WindDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WindEFCore.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            Street = "Theodor Pallady",
                            StreetNumber = "47"
                        },
                        new
                        {
                            AddressId = 2,
                            Street = "Highway to hell",
                            StreetNumber = "666"
                        },
                        new
                        {
                            AddressId = 3,
                            Street = "Ragnarok",
                            StreetNumber = "13"
                        });
                });

            modelBuilder.Entity("WindEFCore.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            CompanyName = "WindSoft"
                        },
                        new
                        {
                            CompanyId = 2,
                            CompanyName = "Perly Gates"
                        },
                        new
                        {
                            CompanyId = 3,
                            CompanyName = "Valhala INC."
                        });
                });

            modelBuilder.Entity("WindEFCore.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<byte>("Currency")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL(9,2)");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("ClientId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            ClientId = 1,
                            Currency = (byte)2,
                            Price = 10m,
                            ReferenceNumber = "test1"
                        },
                        new
                        {
                            OrderId = 2,
                            ClientId = 1,
                            Currency = (byte)1,
                            Price = 20m,
                            ReferenceNumber = "test2"
                        },
                        new
                        {
                            OrderId = 3,
                            ClientId = 1,
                            Currency = (byte)1,
                            Price = 30m,
                            ReferenceNumber = "test3"
                        },
                        new
                        {
                            OrderId = 4,
                            ClientId = 1,
                            Currency = (byte)3,
                            Price = 40m,
                            ReferenceNumber = "test4"
                        });
                });

            modelBuilder.Entity("WindEFCore.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<byte>("Currency")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TripReference")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.HasIndex("CarrierId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            CarrierId = 1,
                            Currency = (byte)1,
                            Price = 10m,
                            TripReference = "tesd1"
                        },
                        new
                        {
                            TripId = 2,
                            CarrierId = 1,
                            Currency = (byte)1,
                            Price = 20m,
                            TripReference = "tesd1"
                        },
                        new
                        {
                            TripId = 3,
                            CarrierId = 1,
                            Currency = (byte)1,
                            Price = 30m,
                            TripReference = "tesd1"
                        },
                        new
                        {
                            TripId = 4,
                            CarrierId = 1,
                            Currency = (byte)1,
                            Price = 40m,
                            TripReference = "tesd1"
                        },
                        new
                        {
                            TripId = 5,
                            CarrierId = 1,
                            Currency = (byte)1,
                            Price = 50m,
                            TripReference = "tesd1"
                        });
                });

            modelBuilder.Entity("WindEFCore.Models.TripOrders", b =>
                {
                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("TripId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("TripOrders");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            TripId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            TripId = 3,
                            OrderId = 1
                        },
                        new
                        {
                            TripId = 1,
                            OrderId = 2
                        },
                        new
                        {
                            TripId = 4,
                            OrderId = 3
                        },
                        new
                        {
                            TripId = 5,
                            OrderId = 4
                        });
                });

            modelBuilder.Entity("WindEFCore.Models.Address", b =>
                {
                    b.HasOne("WindEFCore.Models.Company", "Company")
                        .WithOne("Address")
                        .HasForeignKey("WindEFCore.Models.Address", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WindEFCore.Models.Order", b =>
                {
                    b.HasOne("WindEFCore.Models.Company", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("WindEFCore.Models.Trip", b =>
                {
                    b.HasOne("WindEFCore.Models.Company", "Carrier")
                        .WithMany("Trips")
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("WindEFCore.Models.TripOrders", b =>
                {
                    b.HasOne("WindEFCore.Models.Order", "Order")
                        .WithMany("TripOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WindEFCore.Models.Trip", "Trip")
                        .WithMany("TripOrders")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
