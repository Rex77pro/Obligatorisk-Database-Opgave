// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hotel_Database_Opgave_15_11_22.Models
{
    public partial class DBOpgaveContext : DbContext
    {
        public DBOpgaveContext()
        {
        }

        public DBOpgaveContext(DbContextOptions<DBOpgaveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DemoBooking> DemoBookings { get; set; }
        public virtual DbSet<DemoGuest> DemoGuests { get; set; }
        public virtual DbSet<DemoHotel> DemoHotels { get; set; }
        public virtual DbSet<DemoRoom> DemoRooms { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"DBOpgave \";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DemoBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__DemoBook__35AAE1F8CBFCFE22");

                entity.HasOne(d => d.GuestNoNavigation)
                    .WithMany(p => p.DemoBookings)
                    .HasForeignKey(d => d.GuestNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DemoBooki__Guest__300424B4");

                entity.HasOne(d => d.DemoRoom)
                    .WithMany(p => p.DemoBookings)
                    .HasForeignKey(d => new { d.RoomNo, d.HotelNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DemoBooking__30F848ED");
            });

            modelBuilder.Entity<DemoGuest>(entity =>
            {
                entity.HasKey(e => e.GuestNo)
                    .HasName("PK__DemoGues__CB8B32A0F13AC72C");

                entity.Property(e => e.GuestNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<DemoHotel>(entity =>
            {
                entity.HasKey(e => e.HotelNo)
                    .HasName("PK__DemoHote__AA4F173EF99E0607");

                entity.Property(e => e.HotelNo).ValueGeneratedNever();

                entity.HasMany(d => d.FacilityNos)
                    .WithMany(p => p.HotelNos)
                    .UsingEntity<Dictionary<string, object>>(
                        "HotelFacility",
                        l => l.HasOne<Facility>().WithMany().HasForeignKey("FacilityNo").HasConstraintName("FK__HotelFaci__Facil__37A5467C"),
                        r => r.HasOne<DemoHotel>().WithMany().HasForeignKey("HotelNo").HasConstraintName("FK__HotelFaci__Hotel__36B12243"),
                        j =>
                        {
                            j.HasKey("HotelNo", "FacilityNo").HasName("PK__HotelFac__16A5B08ABF8CC103");

                            j.ToTable("HotelFacilities");

                            j.IndexerProperty<int>("HotelNo").HasColumnName("Hotel_No");

                            j.IndexerProperty<int>("FacilityNo").HasColumnName("Facility_No");
                        });
            });

            modelBuilder.Entity<DemoRoom>(entity =>
            {
                entity.HasKey(e => new { e.RoomNo, e.HotelNo })
                    .HasName("PK__DemoRoom__E34B708F8A1E7ACA");

                entity.Property(e => e.Types)
                    .HasDefaultValueSql("('S')")
                    .IsFixedLength();

                entity.HasOne(d => d.HotelNoNavigation)
                    .WithMany(p => p.DemoRooms)
                    .HasForeignKey(d => d.HotelNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DemoRoom__Hotel___2B3F6F97");
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.HasKey(e => e.FacilityNo)
                    .HasName("PK__Faciliti__CEAA7B4A0F822894");

                entity.Property(e => e.FacilityNo).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}