using HotelManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> entity)
        {
            entity.ToTable("Reservations");

            entity.Property(e => e.AptSuite)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.ArrivalTime)
                .HasColumnType("date");

            entity.Property(e => e.BirthDay)
                .IsRequired()
                .HasColumnType("date")
                .HasMaxLength(50);

            entity.Property(e => e.BreakFast);

            entity.Property(e => e.CardCvc)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            entity.Property(e => e.CardExp)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.CardNumber)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.CardType)
                .IsRequired()

                .HasMaxLength(10)
                .IsFixedLength();

            entity.Property(e => e.CheckIn);

            entity.Property(e => e.City)
                .IsRequired();

            entity.Property(e => e.Cleaning);

            entity.Property(e => e.Dinner);

            entity.Property(e => e.EmailAddress)
                .IsRequired();

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.FoodBill);

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.LeavingTime)
                .HasColumnType("date");

            entity.Property(e => e.Lunch);

            entity.Property(e => e.NumberGuest);

            entity.Property(e => e.PaymentType)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.RoomFloor)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            entity.Property(e => e.RoomNumber)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            entity.Property(e => e.RoomType)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            entity.Property(e => e.SSurprise).HasColumnName("s_surprise");

            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.StreetAddress)
                .IsRequired();

            entity.Property(e => e.SupplyStatus);

            entity.Property(e => e.TotalBill);

            entity.Property(e => e.Towel);

            entity.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();
        }
    }
}
