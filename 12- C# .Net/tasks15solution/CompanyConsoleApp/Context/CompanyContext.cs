using CompanyConsoleApp.ConfigurationClasses;
using CompanyConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyConsoleApp.Context
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( "Data source=.;Initial catalog=Company2023DB;Integrated Security=true;Encrypt=false ");
        }

        // mapping no. 3 => fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            #region original style for api
            //modelBuilder.Entity<Client>()
            //    .Ignore(c=>c.TimeStamp)
            //    .HasKey(client => client.CID);

            //modelBuilder.Entity<Client>()
            //    .Property(c=>c.FName).HasMaxLength(50);

            //modelBuilder.Entity<Client>()
            //    .Property(c => c.LName).HasMaxLength(50);

            //modelBuilder.Entity<Client>()
            //    .Property(c => c.MName).HasMaxLength(2).IsFixedLength().IsRequired(false);

            //modelBuilder.Entity<Client>().Property(c => c.Deposit).HasColumnType("Money").HasColumnName("OrderDeposit");

            #endregion

            #region new style for api
            //modelBuilder.Entity<Client>(EntityBuilder => {
            //    EntityBuilder.Ignore(c => c.TimeStamp).HasKey(c => c.CID);
            //    EntityBuilder.Property(c => c.FName).HasMaxLength(50);
            //    EntityBuilder.Property(c => c.LName).HasMaxLength(50);
            //    EntityBuilder.Property(c => c.MName).HasMaxLength(2).IsFixedLength().IsRequired();
            //    EntityBuilder.Property(c => c.Deposit).HasColumnType("money").HasColumnName("OrderDeposit");
            //});
            //modelBuilder.Entity<Branch>(EntityBuilder => {

            //    EntityBuilder.Property(c => c.Name).HasMaxLength(20);
            //    EntityBuilder.Property(c => c.City).HasMaxLength(10).IsUnicode();

            //});
            #endregion

            //4.Configuration class way
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfiguration());


            modelBuilder.Entity<EmployeeClient>().HasKey(EC => new { EC.clientCID, EC.EmployeeEID });

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Branch> Branches { get; set; }


    }
}
