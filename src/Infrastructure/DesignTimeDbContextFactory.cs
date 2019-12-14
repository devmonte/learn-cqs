using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BikeShopDbContext>
    {
        public BikeShopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BikeShopDbContext>();
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=BikeShop;ConnectRetryCount=0;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new BikeShopDbContext(optionsBuilder.Options);
        }
    }
}
