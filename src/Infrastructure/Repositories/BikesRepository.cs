using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Core.Repositories;

namespace Infrastructure.Repositories
{
    public class BikesRepository : IBikesRepository
    {
        private readonly BikeShopDbContext _dbContext;

        public BikesRepository(BikeShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IList<Bike> GetBikes()
        {
            throw new NotImplementedException();
        }

        public void AddBike(Bike bike)
        {
            throw new NotImplementedException();
        }
    }
}
