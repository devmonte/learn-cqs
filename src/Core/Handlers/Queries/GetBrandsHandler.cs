using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Core.Queries;
using Core.Repositories;

namespace Core.Handlers.Queries
{
    public class GetBrandsHandler : IQueryHandler<GetBrands, List<Brand>>
    {
        private readonly IBrandsRepository _brandsRepository;

        public GetBrandsHandler(IBrandsRepository brandsRepository)
        {
            _brandsRepository = brandsRepository;
        }

        public Task<List<Brand>> Handle(GetBrands query)
        {
            return Task.FromResult(_brandsRepository.GetBrands().ToList());
        }
    }
}
