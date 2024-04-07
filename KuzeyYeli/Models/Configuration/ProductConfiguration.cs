using KuzeyYeli.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Models.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //category(Principal) product(dependent)
            builder.ToTable("Product");
            builder
                .HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);

            //order(principal)	Product(dependent)
            builder
                .HasOne(x=>x.Order)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.OrderId);



            builder.Property(x=>x.ProductName).IsRequired();
            builder.Property(x=>x.UnitPrice).IsRequired();
            builder.Property(x=>x.Quantity).IsRequired();
            builder.Property(x=>x.UnitsInStock).IsRequired();

            
               
            
            
        }
    }
}
