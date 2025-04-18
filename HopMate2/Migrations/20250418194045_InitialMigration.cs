using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HopMate2.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMember = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    TotalPoints = table.Column<int>(type: "int", nullable: false),
                    Hops = table.Column<int>(type: "int", nullable: false),
                    DtBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    ImageFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    IdImage = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.IdImage);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    IdLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PC1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PC2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.IdLocation);
                });

            migrationBuilder.CreateTable(
                name: "RequestStatuses",
                columns: table => new
                {
                    IdRequestStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatuses", x => x.IdRequestStatus);
                });

            migrationBuilder.CreateTable(
                name: "Sponsors",
                columns: table => new
                {
                    IdSponsor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsors", x => x.IdSponsor);
                });

            migrationBuilder.CreateTable(
                name: "StatusTrips",
                columns: table => new
                {
                    IdStatusTrip = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTrips", x => x.IdStatusTrip);
                });

            migrationBuilder.CreateTable(
                name: "VoucherStatuses",
                columns: table => new
                {
                    IdVoucherStatus = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherStatuses", x => x.IdVoucherStatus);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    IdDriver = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrivingLicense = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.IdDriver);
                    table.ForeignKey(
                        name: "FK_Drivers_AspNetUsers_IdDriver",
                        column: x => x.IdDriver,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Passengers_AspNetUsers_IdUser",
                        column: x => x.IdUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Penalties",
                columns: table => new
                {
                    IdPenalty = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hops = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    IdMember = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penalties", x => x.IdPenalty);
                    table.ForeignKey(
                        name: "FK_Penalties_AspNetUsers_IdMember",
                        column: x => x.IdMember,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    IdVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HopsCost = table.Column<int>(type: "int", nullable: false),
                    ExpiracyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSponsor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVoucherStatus = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdImage = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.IdVoucher);
                    table.ForeignKey(
                        name: "FK_Vouchers_Images_IdImage",
                        column: x => x.IdImage,
                        principalTable: "Images",
                        principalColumn: "IdImage",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vouchers_Sponsors_IdSponsor",
                        column: x => x.IdSponsor,
                        principalTable: "Sponsors",
                        principalColumn: "IdSponsor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vouchers_VoucherStatuses_IdVoucherStatus",
                        column: x => x.IdVoucherStatus,
                        principalTable: "VoucherStatuses",
                        principalColumn: "IdVoucherStatus",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rewards",
                columns: table => new
                {
                    IdReward = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hops = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDriver = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewards", x => x.IdReward);
                    table.ForeignKey(
                        name: "FK_Rewards_Drivers_IdDriver",
                        column: x => x.IdDriver,
                        principalTable: "Drivers",
                        principalColumn: "IdDriver",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    IdVehicle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    ImageFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDriver = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.IdVehicle);
                    table.ForeignKey(
                        name: "FK_Vehicles_Drivers_IdDriver",
                        column: x => x.IdDriver,
                        principalTable: "Drivers",
                        principalColumn: "IdDriver",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    IdReview = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateReview = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDriver = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPassenger = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.IdReview);
                    table.ForeignKey(
                        name: "FK_Reviews_Drivers_IdDriver",
                        column: x => x.IdDriver,
                        principalTable: "Drivers",
                        principalColumn: "IdDriver",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Passengers_IdPassenger",
                        column: x => x.IdPassenger,
                        principalTable: "Passengers",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberVouchers",
                columns: table => new
                {
                    IdMemberVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateRedeemed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMember = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberVouchers", x => x.IdMemberVoucher);
                    table.ForeignKey(
                        name: "FK_MemberVouchers_AspNetUsers_IdMember",
                        column: x => x.IdMember,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberVouchers_Vouchers_IdVoucher",
                        column: x => x.IdVoucher,
                        principalTable: "Vouchers",
                        principalColumn: "IdVoucher",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    IdTrip = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateDeparture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableSeats = table.Column<int>(type: "int", nullable: false),
                    IdDriver = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverIdDriver = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVehicle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdStatusTrip = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.IdTrip);
                    table.ForeignKey(
                        name: "FK_Trips_Drivers_DriverIdDriver",
                        column: x => x.DriverIdDriver,
                        principalTable: "Drivers",
                        principalColumn: "IdDriver",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trips_StatusTrips_IdStatusTrip",
                        column: x => x.IdStatusTrip,
                        principalTable: "StatusTrips",
                        principalColumn: "IdStatusTrip",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trips_Vehicles_IdVehicle",
                        column: x => x.IdVehicle,
                        principalTable: "Vehicles",
                        principalColumn: "IdVehicle",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PassengerTrips",
                columns: table => new
                {
                    IdPassengerTrip = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPassenger = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTrip = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRequestStatus = table.Column<int>(type: "int", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerTrips", x => x.IdPassengerTrip);
                    table.ForeignKey(
                        name: "FK_PassengerTrips_Locations_IdLocation",
                        column: x => x.IdLocation,
                        principalTable: "Locations",
                        principalColumn: "IdLocation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassengerTrips_Passengers_IdPassenger",
                        column: x => x.IdPassenger,
                        principalTable: "Passengers",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PassengerTrips_RequestStatuses_IdRequestStatus",
                        column: x => x.IdRequestStatus,
                        principalTable: "RequestStatuses",
                        principalColumn: "IdRequestStatus",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassengerTrips_Trips_IdTrip",
                        column: x => x.IdTrip,
                        principalTable: "Trips",
                        principalColumn: "IdTrip",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TripLocation",
                columns: table => new
                {
                    IdTripLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTrip = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsStart = table.Column<bool>(type: "bit", nullable: false),
                    LocationIdLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripLocation", x => x.IdTripLocation);
                    table.ForeignKey(
                        name: "FK_TripLocation_Locations_IdLocation",
                        column: x => x.IdLocation,
                        principalTable: "Locations",
                        principalColumn: "IdLocation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripLocation_Locations_LocationIdLocation",
                        column: x => x.LocationIdLocation,
                        principalTable: "Locations",
                        principalColumn: "IdLocation");
                    table.ForeignKey(
                        name: "FK_TripLocation_Trips_IdTrip",
                        column: x => x.IdTrip,
                        principalTable: "Trips",
                        principalColumn: "IdTrip",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MemberVouchers_IdMember",
                table: "MemberVouchers",
                column: "IdMember");

            migrationBuilder.CreateIndex(
                name: "IX_MemberVouchers_IdVoucher",
                table: "MemberVouchers",
                column: "IdVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerTrips_IdLocation",
                table: "PassengerTrips",
                column: "IdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerTrips_IdPassenger",
                table: "PassengerTrips",
                column: "IdPassenger");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerTrips_IdRequestStatus",
                table: "PassengerTrips",
                column: "IdRequestStatus");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerTrips_IdTrip",
                table: "PassengerTrips",
                column: "IdTrip");

            migrationBuilder.CreateIndex(
                name: "IX_Penalties_IdMember",
                table: "Penalties",
                column: "IdMember");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_IdDriver",
                table: "Reviews",
                column: "IdDriver");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_IdPassenger",
                table: "Reviews",
                column: "IdPassenger");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_IdDriver",
                table: "Rewards",
                column: "IdDriver");

            migrationBuilder.CreateIndex(
                name: "IX_TripLocation_IdLocation",
                table: "TripLocation",
                column: "IdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_TripLocation_IdTrip",
                table: "TripLocation",
                column: "IdTrip");

            migrationBuilder.CreateIndex(
                name: "IX_TripLocation_LocationIdLocation",
                table: "TripLocation",
                column: "LocationIdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DriverIdDriver",
                table: "Trips",
                column: "DriverIdDriver");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_IdStatusTrip",
                table: "Trips",
                column: "IdStatusTrip");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_IdVehicle",
                table: "Trips",
                column: "IdVehicle");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_IdDriver",
                table: "Vehicles",
                column: "IdDriver");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_IdImage",
                table: "Vouchers",
                column: "IdImage");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_IdSponsor",
                table: "Vouchers",
                column: "IdSponsor");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_IdVoucherStatus",
                table: "Vouchers",
                column: "IdVoucherStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MemberVouchers");

            migrationBuilder.DropTable(
                name: "PassengerTrips");

            migrationBuilder.DropTable(
                name: "Penalties");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Rewards");

            migrationBuilder.DropTable(
                name: "TripLocation");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "RequestStatuses");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Sponsors");

            migrationBuilder.DropTable(
                name: "VoucherStatuses");

            migrationBuilder.DropTable(
                name: "StatusTrips");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
