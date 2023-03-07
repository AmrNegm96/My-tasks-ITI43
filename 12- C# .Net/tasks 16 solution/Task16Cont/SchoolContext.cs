using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16Cont
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data source=.;Initial Catalog=ITISchoolDB;Integrated Security=true;Encrypt=false");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// user defined discriminator
            //modelBuilder.Entity<Person>()
            //    .HasDiscriminator(p => p.IsEmployee)
            //    .HasValue<Teacher>(true)
            //    .HasValue<Student>(false);

            //default discriminator
            //    modelBuilder.Entity<Person>().
            //        Property("Discriminator").
            //        HasMaxLength(50);
            //modelBuilder.Entity<Person>().UseTphMappingStrategy(); //default
            
            modelBuilder.Entity<Person>().UseTpcMappingStrategy(); //table per concrete class mapping //must remove the dbset of person 

            base.OnModelCreating(modelBuilder);
        }
        //public virtual DbSet<Person> People { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<Student> Students { get; set; }
    }
}
