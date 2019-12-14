using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class BikeShopDbContext : DbContext
    {
        public BikeShopDbContext(DbContextOptions<BikeShopDbContext> options) : base(options)
        {

        }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
