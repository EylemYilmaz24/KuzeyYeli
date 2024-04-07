using KuzeyYeli.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Models.Configuration
{
    public class ProductSupplierConfiguration : IEntityTypeConfiguration<ProductSupplier>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductSupplier> builder)
        {
            builder
                .HasKey(x => new { x.ProductId, x.SupplierId });
            builder
                .HasOne(x => x.Supplier)
                .WithMany(x => x.ProductSuppliers)
                .HasPrincipalKey(x => x.ID);
            builder
                .HasOne(x => x.Product)
                .WithMany(x=>x.ProductSuppliers)
                .HasPrincipalKey(x=> x.ID);
        }
    }
}
