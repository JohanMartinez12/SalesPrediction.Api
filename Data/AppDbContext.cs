using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesPrediction.Api.Models;
using System.Data.Common;

namespace SalesPrediction.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Aquí defines tus DbSet<T> (tablas)

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrdersDetail> OrderDetails { get; set; }
        //DTO's
        public DbSet<PredictionDTO> PredictionDtos { get; set; }
        public DbSet<ClientOrderDTO> ClientOrderDtos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PredictionDTO>().HasNoKey(); // Es una consulta, no tabla
            modelBuilder.Entity<OrdersDetail>()
                .HasKey(od => new { od.Orderid, od.Productid });
            modelBuilder.Entity<ClientOrderDTO>().HasNoKey(); // Es una consulta, no tabla
        }

    }
}
