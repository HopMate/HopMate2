﻿// <auto-generated />
using System;
using HopMate2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HopMate2.Migrations
{
    [DbContext(typeof(HopMateContext))]
    [Migration("20250418194500_Location")]
    partial class Location
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HopMate2.Models.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DtBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Hops")
                        .HasColumnType("int");

                    b.Property<Guid>("IdMember")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageFilePath")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPoints")
                        .HasColumnType("int");

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

            modelBuilder.Entity("HopMate2.Models.Entities.Driver", b =>
                {
                    b.Property<Guid>("IdDriver")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DrivingLicense")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDriver");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Image", b =>
                {
                    b.Property<Guid>("IdImage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdImage");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Location", b =>
                {
                    b.Property<Guid>("IdLocation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PC1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PC2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLocation");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.MemberVoucher", b =>
                {
                    b.Property<Guid>("IdMemberVoucher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateRedeemed")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdMember")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdVoucher")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdMemberVoucher");

                    b.HasIndex("IdMember");

                    b.HasIndex("IdVoucher");

                    b.ToTable("MemberVouchers");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Passenger", b =>
                {
                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdUser");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.PassengerTrip", b =>
                {
                    b.Property<Guid>("IdPassengerTrip")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateRequest")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdLocation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPassenger")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IdRequestStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("IdTrip")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPassengerTrip");

                    b.HasIndex("IdLocation");

                    b.HasIndex("IdPassenger");

                    b.HasIndex("IdRequestStatus");

                    b.HasIndex("IdTrip");

                    b.ToTable("PassengerTrips");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Penalty", b =>
                {
                    b.Property<Guid>("IdPenalty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Hops")
                        .HasColumnType("int");

                    b.Property<Guid>("IdMember")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("IdPenalty");

                    b.HasIndex("IdMember");

                    b.ToTable("Penalties");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.RequestStatus", b =>
                {
                    b.Property<int>("IdRequestStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRequestStatus"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRequestStatus");

                    b.ToTable("RequestStatuses");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Review", b =>
                {
                    b.Property<Guid>("IdReview")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateReview")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdDriver")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPassenger")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("IdReview");

                    b.HasIndex("IdDriver");

                    b.HasIndex("IdPassenger");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Reward", b =>
                {
                    b.Property<Guid>("IdReward")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Hops")
                        .HasColumnType("int");

                    b.Property<Guid>("IdDriver")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReward");

                    b.HasIndex("IdDriver");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Sponsor", b =>
                {
                    b.Property<Guid>("IdSponsor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSponsor");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.StatusTrip", b =>
                {
                    b.Property<Guid>("IdStatusTrip")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdStatusTrip");

                    b.ToTable("StatusTrips");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Trip", b =>
                {
                    b.Property<Guid>("IdTrip")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateArrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDeparture")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DriverIdDriver")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdDriver")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdStatusTrip")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdVehicle")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdTrip");

                    b.HasIndex("DriverIdDriver");

                    b.HasIndex("IdStatusTrip");

                    b.HasIndex("IdVehicle");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.TripLocation", b =>
                {
                    b.Property<Guid>("IdTripLocation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLocation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTrip")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsStart")
                        .HasColumnType("bit");

                    b.HasKey("IdTripLocation");

                    b.HasIndex("IdLocation");

                    b.HasIndex("IdTrip");

                    b.ToTable("TripLocation");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Vehicle", b =>
                {
                    b.Property<Guid>("IdVehicle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdDriver")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageFilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.HasKey("IdVehicle");

                    b.HasIndex("IdDriver");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Voucher", b =>
                {
                    b.Property<Guid>("IdVoucher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiracyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HopsCost")
                        .HasColumnType("int");

                    b.Property<Guid>("IdImage")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSponsor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdVoucherStatus")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVoucher");

                    b.HasIndex("IdImage");

                    b.HasIndex("IdSponsor");

                    b.HasIndex("IdVoucherStatus");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.VoucherStatus", b =>
                {
                    b.Property<Guid>("IdVoucherStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVoucherStatus");

                    b.ToTable("VoucherStatuses");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Driver", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("IdDriver")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.MemberVoucher", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.ApplicationUser", "Member")
                        .WithMany("MemberVouchers")
                        .HasForeignKey("IdMember")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.Voucher", "Voucher")
                        .WithMany("MemberVouchers")
                        .HasForeignKey("IdVoucher")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Passenger", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.PassengerTrip", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("IdLocation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.Passenger", "Passenger")
                        .WithMany("PassengerTrips")
                        .HasForeignKey("IdPassenger")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.RequestStatus", "RequestStatus")
                        .WithMany("PassengerTrips")
                        .HasForeignKey("IdRequestStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.Trip", "Trip")
                        .WithMany("PassengerTrips")
                        .HasForeignKey("IdTrip")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Passenger");

                    b.Navigation("RequestStatus");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Penalty", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.ApplicationUser", "Member")
                        .WithMany("Penalties")
                        .HasForeignKey("IdMember")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Review", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.Driver", "Driver")
                        .WithMany("Reviews")
                        .HasForeignKey("IdDriver")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.Passenger", "Passenger")
                        .WithMany("Reviews")
                        .HasForeignKey("IdPassenger")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Reward", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.Driver", "Driver")
                        .WithMany("Rewards")
                        .HasForeignKey("IdDriver")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Trip", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.Driver", "Driver")
                        .WithMany("Trips")
                        .HasForeignKey("DriverIdDriver")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.StatusTrip", "StatusTrip")
                        .WithMany("Trips")
                        .HasForeignKey("IdStatusTrip")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.Vehicle", "Vehicle")
                        .WithMany("Trips")
                        .HasForeignKey("IdVehicle")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("StatusTrip");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.TripLocation", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.Location", "Location")
                        .WithMany("TripLocations")
                        .HasForeignKey("IdLocation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.Trip", "Trip")
                        .WithMany("TripLocations")
                        .HasForeignKey("IdTrip")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Vehicle", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.Driver", "Driver")
                        .WithMany("Vehicles")
                        .HasForeignKey("IdDriver")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Voucher", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.Image", "Image")
                        .WithMany("Vouchers")
                        .HasForeignKey("IdImage")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.Sponsor", "Sponsor")
                        .WithMany("Vouchers")
                        .HasForeignKey("IdSponsor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.VoucherStatus", "VoucherStatus")
                        .WithMany("Vouchers")
                        .HasForeignKey("IdVoucherStatus")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("Sponsor");

                    b.Navigation("VoucherStatus");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HopMate2.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("HopMate2.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HopMate2.Models.Entities.ApplicationUser", b =>
                {
                    b.Navigation("MemberVouchers");

                    b.Navigation("Penalties");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Driver", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Rewards");

                    b.Navigation("Trips");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Image", b =>
                {
                    b.Navigation("Vouchers");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Location", b =>
                {
                    b.Navigation("TripLocations");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Passenger", b =>
                {
                    b.Navigation("PassengerTrips");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.RequestStatus", b =>
                {
                    b.Navigation("PassengerTrips");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Sponsor", b =>
                {
                    b.Navigation("Vouchers");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.StatusTrip", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Trip", b =>
                {
                    b.Navigation("PassengerTrips");

                    b.Navigation("TripLocations");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Vehicle", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.Voucher", b =>
                {
                    b.Navigation("MemberVouchers");
                });

            modelBuilder.Entity("HopMate2.Models.Entities.VoucherStatus", b =>
                {
                    b.Navigation("Vouchers");
                });
#pragma warning restore 612, 618
        }
    }
}
