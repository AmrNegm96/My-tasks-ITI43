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
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> entity)
        {
            entity.ToTable("LoginData");

            entity.HasKey(e => new { e.UserName , e.IsAdmin});

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.IsAdmin)
                .IsRequired();

        }
    }
}
