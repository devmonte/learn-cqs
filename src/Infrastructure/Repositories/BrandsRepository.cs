using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Core.Repositories;

namespace Infrastructure.Repositories
{
    public class BrandsRepository : IBrandsRepository
    {
        private readonly BikeShopDbContext _dbContext;

        public BrandsRepository(BikeShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBrand(Brand brand)
        {
            _dbContext.Add(new Core.Entities.Brand
            {
                Name = brand.Name
            });
            _dbContext.SaveChanges();
        }
    }
}
