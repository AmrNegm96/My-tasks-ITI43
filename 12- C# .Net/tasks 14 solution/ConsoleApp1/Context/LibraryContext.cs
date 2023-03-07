using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Context
{
    internal class LibraryContext :DbContext
    {
        //public LibraryContext()
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=.;Initial Catalog=LibraryDB;Integrated Security=true;Encrypt=false");
        }


        //the local copy of object we get from data base (Stroage offline)
        //for each table you need to map it to database use Dbset
        public virtual DbSet<Title> Titles { get; set; }

        //new form

        public DbSet<Branch> Branches => Set<Branch>();
    }
}
