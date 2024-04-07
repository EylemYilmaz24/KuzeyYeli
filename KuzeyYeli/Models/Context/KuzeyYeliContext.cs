using KuzeyYeli.Models.Configuration;
using KuzeyYeli.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Models.Context
{
    public class KuzeyYeliContext:DbContext
    {
        //DbSet
        DbSet<Category> Categories;
        DbSet<Customer> Customers;
        DbSet<Order> Orders;
        DbSet<Product> Products;
        DbSet<Shipper> Shippers;
        DbSet<Supplier> Suppliers;


        //Connection(Onconfiguring)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server = LAPTOP-KVVGNCFL\\SQLEXPRESS; database = KuzeyYeli; Trusted_Connection = true; TrustServerCertificate = true");
            }


            base.OnConfiguring(optionsBuilder);
        }

        //OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSupplierConfiguration());
            modelBuilder.ApplyConfiguration(new ShipperConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());

            base.OnModelCreating(modelBuilder);

        }





    }
}
