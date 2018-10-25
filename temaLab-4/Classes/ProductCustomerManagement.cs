using System;
using Microsoft.EntityFrameworkCore;

namespace Classes
{
    public class ProductCustomerManagement : DbContext
    {
        public ProductCustomerManagement()
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=Tema4;Trusted_Connection=True;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            modelBuilder.Entity<Customer>()
                .Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(300);

            modelBuilder.Entity<Customer>()
                .Property(t => t.PhoneNumber)
                .IsRequired();
            
            modelBuilder.Entity<Customer>()
                .Property(t => t.Email)
                .IsRequired();
        }
    }
}