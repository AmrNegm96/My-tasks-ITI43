using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myReverseEngineering.MyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace myReverseEngineering.MyConfigurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> e)
        {
                e.HasIndex(e => e.CategoryId, "CategoryID");
                e.HasIndex(e => e.ProductName, "ProductName");
                e.HasIndex(e => e.SupplierId, "SupplierID");

                e.Property(e => e.ProductId).HasColumnName("ProductID");
                e.Property(e => e.CategoryId).HasColumnName("CategoryID");

                e.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(40);

                e.Property(e => e.QuantityPerUnit).HasMaxLength(20);
                e.Property(e => e.ReorderLevel).HasDefaultValueSql("((0))");
                e.Property(e => e.SupplierId).HasColumnName("SupplierID");

                e.Property(e => e.UnitPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");

                e.Property(e => e.UnitsInStock).HasDefaultValueSql("((0))");
                e.Property(e => e.UnitsOnOrder).HasDefaultValueSql("((0))");

                e.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Products_Categories");

                e.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Products_Suppliers");
        }
    }
}
