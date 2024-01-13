using BurgerShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerShop.AppClases
{
    public class BurgerShopContext : DbContext
    {
        public BurgerShopContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BurgerName> BurgerNames { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
