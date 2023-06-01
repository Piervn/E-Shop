using Microsoft.EntityFrameworkCore;
using E_Shop.Domain.Entities;

namespace E_Shop.Infrastructure
{
    public class E_ShopDbContext : DbContext
    {
        public E_ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().OwnsOne(p => p.Address);
            modelBuilder.Entity<Manager>().OwnsOne(p => p.Address);
            modelBuilder.Entity<Order>().OwnsOne(p => p.DeliveryAdress);
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Manager> Manager { get; set; }
    }
}