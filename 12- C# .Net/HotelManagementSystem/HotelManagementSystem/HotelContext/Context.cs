using HotelManagementSystem.Configurations;
using HotelManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.HotelContext
{
    public class Context : DbContext
    {
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Login> Logins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HotelManagementSystem;Integrated Security=True;Encrypt=false");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoginConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
