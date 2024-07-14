﻿// <auto-generated />
using System;
using Booking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Booking.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240714044328_addedDetailsIntoLog")]
    partial class addedDetailsIntoLog
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Booking.Domain.Entities.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date_19118162")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VillaId");

                    b.ToTable("Amenities", "19118162");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7123),
                            Name = "Private Pool",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7128),
                            Name = "Microwave",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7132),
                            Name = "Private Balcony",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 4,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7157),
                            Name = "1 king bed and 1 sofa bed",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 5,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7162),
                            Name = "Private Plunge Pool",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 6,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7165),
                            Name = "Microwave and Mini Refrigerator",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 7,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7169),
                            Name = "Private Balcony",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 8,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7172),
                            Name = "King bed or 2 double beds",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 9,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7176),
                            Name = "Private Pool",
                            VillaId = 3
                        },
                        new
                        {
                            Id = 10,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7179),
                            Name = "Jacuzzi",
                            VillaId = 3
                        },
                        new
                        {
                            Id = 11,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7183),
                            Name = "Private Balcony",
                            VillaId = 3
                        });
                });

            modelBuilder.Entity("Booking.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Booking.Domain.Entities.Log_19118162", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Log_19118162", "19118162");
                });

            modelBuilder.Entity("Booking.Domain.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ActualCheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ActualCheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("CheckInDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("CheckOutDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("Date_19118162")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPaymentSuccessful")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nights")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StripePaymentIntentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StripeSessionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.Property<int>("VillaNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VillaId");

                    b.ToTable("Reservations", "19118162");
                });

            modelBuilder.Entity("Booking.Domain.Entities.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_19118162")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas", "19118162");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(6606),
                            Description = "Villa, country estate, complete with house, grounds, and subsidiary buildings.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Price = 200.0,
                            Sqft = 550
                        },
                        new
                        {
                            Id = 2,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(6663),
                            Description = "Villa, country estate, complete with house, grounds, and subsidiary buildings.",
                            ImageUrl = "https://placehold.co/600x401",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Price = 300.0,
                            Sqft = 550
                        },
                        new
                        {
                            Id = 3,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(6668),
                            Description = "Villa, country estate, complete with house, grounds, and subsidiary buildings.",
                            ImageUrl = "https://placehold.co/600x402",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Price = 400.0,
                            Sqft = 750
                        });
                });

            modelBuilder.Entity("Booking.Domain.Entities.VillaNumber", b =>
                {
                    b.Property<int>("Villa_Number")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_19118162")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("Villa_Number");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers", "19118162");

                    b.HasData(
                        new
                        {
                            Villa_Number = 101,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7020),
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 102,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7025),
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 103,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7034),
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 104,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7048),
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 201,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7051),
                            VillaId = 2
                        },
                        new
                        {
                            Villa_Number = 202,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7054),
                            VillaId = 2
                        },
                        new
                        {
                            Villa_Number = 203,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7058),
                            VillaId = 2
                        },
                        new
                        {
                            Villa_Number = 301,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7063),
                            VillaId = 3
                        },
                        new
                        {
                            Villa_Number = 302,
                            Date_19118162 = new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7067),
                            VillaId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Booking.Domain.Entities.Amenity", b =>
                {
                    b.HasOne("Booking.Domain.Entities.Villa", "Villa")
                        .WithMany("VillaAmenity")
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("Booking.Domain.Entities.Reservation", b =>
                {
                    b.HasOne("Booking.Domain.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.Domain.Entities.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("Booking.Domain.Entities.VillaNumber", b =>
                {
                    b.HasOne("Booking.Domain.Entities.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Booking.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Booking.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Booking.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Booking.Domain.Entities.Villa", b =>
                {
                    b.Navigation("VillaAmenity");
                });
#pragma warning restore 612, 618
        }
    }
}