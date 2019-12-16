using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.Models;
using Core.Queries;
using Core.Repositories;
using MediatR;

namespace Core.Handlers.Queries
{
    public class GetBrandsHandler : IRequestHandler<GetBrands, List<Brand>>
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

        public Task<List<Brand>> Handle(GetBrands request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_brandsRepository.GetBrands().ToList());
        }
    }
}
