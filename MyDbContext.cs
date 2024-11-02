using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplication1
{
    public class MyDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<File> Files { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-many relationship between User and Orders
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);

            // Configure one-to-many relationship between Order and Products
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Products)
                .WithOne()
                .HasForeignKey(p => p.FileId);

            // Configure one-to-one relationship between Product and File
            modelBuilder.Entity<Product>()
                .HasOne(p => p.File)
                .WithOne()
                .HasForeignKey<Product>(p => p.FileId);
        }
    }
}
