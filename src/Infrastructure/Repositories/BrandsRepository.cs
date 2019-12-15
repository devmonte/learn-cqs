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
    public class BrandsRepository : IBrandsRepository
    {
        private readonly BikeShopDbContext _dbContext;
        private readonly IMapper _mapper;

        public BrandsRepository(BikeShopDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void AddBrand(Brand brand)
        {
            _dbContext.Add(new Core.Entities.Brand
            {
                Name = brand.Name
            });
            _dbContext.SaveChanges();
        }

        public IList<Brand> GetBrands()
        {
            var brands = _dbContext.Brands.ToList();
            return _mapper.Map<List<Brand>>(brands);
        }
    }
}
