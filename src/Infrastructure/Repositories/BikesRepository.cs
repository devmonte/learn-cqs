using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Models;
using Core.Repositories;

namespace Infrastructure.Repositories
{
    public class BikesRepository : IBikesRepository
    {
        private readonly BikeShopDbContext _dbContext;
        private readonly IMapper _mapper;

        public BikesRepository(BikeShopDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public IList<Bike> GetBikes()
        {
            var bikes = _dbContext.Bikes.ToList();
            return _mapper.Map<List<Bike>>(bikes);
        }

        public void AddBike(Bike bike)
        {
            var bikeToAdd = _mapper.Map<Core.Entities.Bike>(bike);
            _dbContext.Bikes.Add(bikeToAdd);
            _dbContext.SaveChanges();
        }
    }
}
