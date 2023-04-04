using CompanyConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CompanyConsoleApp.ConfigurationClasses
{
    public class EntityConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> EntityBuilder)
        {

            EntityBuilder.Ignore(c => c.TimeStamp).HasKey(c => c.CID);
            EntityBuilder.Property(c => c.FName).HasMaxLength(50);
            EntityBuilder.Property(c => c.LName).HasMaxLength(50);
            EntityBuilder.Property(c => c.MName).HasMaxLength(2).IsFixedLength().IsRequired();
            EntityBuilder.Property(c => c.Deposit).HasColumnType("money").HasColumnName("OrderDeposit");

        }
    }
}
