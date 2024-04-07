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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(x => x.ID);

            //shipper(principal)	order(dependent)

            builder
                .HasOne(x => x.Shipper)
                .WithMany(x => x.OrderList)
                .HasForeignKey(x => x.ShipperId);


            //customer(principal)	order(dependent)

            builder
                .HasOne(x=>x.Customer)
                .WithMany(x=>x.OrderList)
                .HasForeignKey(x => x.CustomerId);

        }
    }
}
