using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PointOfSale.Connection
{
    public class SqliteDBContextConn:DbContext
    {
        public DbSet<Product> prod { get; set; }
        public DbSet<Printer> printer { get; set; }
        public DbSet<PointOfSales> pos { get; set; }
        public DbSet<CutSale> cut { get; set; }
        public DbSet<PointOfSale_Product> PointOfSale_Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "FileName=PointOfSale.db", sqliteOptionsAction: option =>
            {
                option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>(entity=>
            {
                entity.HasKey(p=>p.ID);
                //entity.HasOne(p => p.ProductCode);
            });
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PointOfSales>().ToTable("PointOfSale");
            modelBuilder.Entity<PointOfSales>(entity =>
            {
                entity.HasKey(p => p.ID);
            });
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CutSale>().ToTable("CutSale");
            modelBuilder.Entity<CutSale>(entity =>
            {
                entity.HasKey(p => p.ID);
            });
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Printer>().ToTable("Printer");
            modelBuilder.Entity<Printer>(entity =>
            {
                entity.HasKey(p => p.ID);
            });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PointOfSale_Product>().ToTable("PoinOfSale_Product");
            modelBuilder.Entity<PointOfSale_Product>(entity =>
            {
                entity.HasKey(p => p.ID);
            });
            base.OnModelCreating(modelBuilder);

        }
    }
}
