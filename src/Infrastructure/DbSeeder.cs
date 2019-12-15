using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Bike = Core.Entities.Bike;
using Brand = Core.Entities.Brand;

namespace Infrastructure
{
    public class DbSeeder
    {
        private readonly BikeShopDbContext _dbContext;

        public DbSeeder(BikeShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedData()
        {
            if (!_dbContext.Brands.Any())
            {
                var bike = new Bike
                {
                    Name = "Trek 1",
                    Price = 2500
                };
                var bike2 = new Bike
                {
                    Name = "Trek 2",
                    Price = 3500
                };
                var kross = new Brand
                {
                    Name = "Kross",
                    Country = "Poland",
                    FoundationYear = new DateTime(2005, 10, 10),
                    Bikes = new List<Bike> {bike, bike2}
                };

                _dbContext.Brands.Add(kross);
                _dbContext.SaveChanges();
            }
        }
    }
}
