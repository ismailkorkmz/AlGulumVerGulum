using Entity.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x=>x.Name).HasColumnName("ProductName").HasColumnType("nvarchar(50)").IsRequired();
            builder.HasMany(x => x.ProductImage).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);
        }
    }
}
