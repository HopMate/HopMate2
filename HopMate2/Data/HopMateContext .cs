using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HopMate2.Models.Entities;

namespace HopMate2.Data
{
    public class HopMateContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public HopMateContext(DbContextOptions<HopMateContext> options)
            : base(options)
        {
        }

        // DbSets para todas as entidades
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Penalty> Penalties { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<MemberVoucher> MemberVouchers { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<VoucherStatus> VoucherStatuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<PassengerTrip> PassengerTrips { get; set; }
        public DbSet<RequestStatus> RequestStatuses { get; set; }
        public DbSet<StatusTrip> StatusTrips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<TripLocation>()
            .HasOne(tl => tl.Trip)
            .WithMany(t => t.TripLocations)
            .HasForeignKey(tl => tl.IdTrip);

            modelBuilder.Entity<TripLocation>()
            .HasOne(tl => tl.Location)
            .WithMany(l => l.TripLocations) // 1:N
            .HasForeignKey(tl => tl.IdLocation);

            // Relacionamento entre Review e Driver
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Driver)
                .WithMany(d => d.Reviews)
                .HasForeignKey(r => r.IdDriver)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre Review e Passenger
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Passenger)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.IdPassenger)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre Driver e Vehicle (1:N)
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Driver)
                .WithMany(d => d.Vehicles)
                .HasForeignKey(v => v.IdDriver)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre Vehicle e Trip (1:N)
            modelBuilder.Entity<Trip>()
                .HasOne(t => t.Vehicle)
                .WithMany(v => v.Trips)
                .HasForeignKey(t => t.IdVehicle)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre Driver e Reward (1:N)
            modelBuilder.Entity<Reward>()
                .HasOne(r => r.Driver)
                .WithMany(d => d.Rewards)
                .HasForeignKey(r => r.IdDriver)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre Driver e Penalty (1:N)
            modelBuilder.Entity<Penalty>()
                .HasOne(p => p.Member)
                .WithMany(d => d.Penalties)
                .HasForeignKey(p => p.IdMember)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre MemberVoucher e Voucher (N:1)
            modelBuilder.Entity<MemberVoucher>()
                .HasOne(mv => mv.Voucher)
                .WithMany(v => v.MemberVouchers)
                .HasForeignKey(mv => mv.IdVoucher)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre MemberVoucher e ApplicationUser (N:1)
            modelBuilder.Entity<MemberVoucher>()
                .HasOne(mv => mv.Member)
                .WithMany(m => m.MemberVouchers)
                .HasForeignKey(mv => mv.IdMember)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre Sponsor e Voucher (1:N)
            modelBuilder.Entity<Voucher>()
                .HasOne(v => v.Sponsor)
                .WithMany(s => s.Vouchers)
                .HasForeignKey(v => v.IdSponsor)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre VoucherStatus e Voucher (1:N)
            modelBuilder.Entity<Voucher>()
                .HasOne(v => v.VoucherStatus)
                .WithMany(vs => vs.Vouchers)
                .HasForeignKey(v => v.IdVoucherStatus)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre Voucher e Image (1:N)
            modelBuilder.Entity<Voucher>()
                .HasOne(v => v.Image)
                .WithMany(i => i.Vouchers)
                .HasForeignKey(v => v.IdImage)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre PassengerTrip e Passenger (N:1)
            modelBuilder.Entity<PassengerTrip>()
                .HasOne(pt => pt.Passenger)
                .WithMany(p => p.PassengerTrips)
                .HasForeignKey(pt => pt.IdPassenger)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre PassengerTrip e Trip (N:1)
            modelBuilder.Entity<PassengerTrip>()
                .HasOne(pt => pt.Trip)
                .WithMany(t => t.PassengerTrips)
                .HasForeignKey(pt => pt.IdTrip)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre StatusTrip e Trip (1:N)
            modelBuilder.Entity<Trip>()
                .HasOne(t => t.StatusTrip)
                .WithMany(st => st.Trips)
                .HasForeignKey(t => t.IdStatusTrip)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
