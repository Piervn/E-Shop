using Microsoft.EntityFrameworkCore;
using E_Shop.Domain.Entities;

namespace E_Shop.Infrastructure
{
    public class E_ShopDbContext : DbContext
    {
        public E_ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}