using CompanyConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyConsoleApp.ConfigurationClasses
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> EntityBuilder)
        {
            EntityBuilder.Property(c => c.Name).HasMaxLength(20);
            EntityBuilder.Property(c => c.City).HasMaxLength(10).IsUnicode();
        }
    }
}
