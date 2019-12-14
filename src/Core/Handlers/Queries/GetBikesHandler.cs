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
    public class GetBikesHandler : IQueryHandler<GetBikes, List<Bike>>
    {
        private readonly IBikesRepository _bikesRepository;

        public GetBikesHandler(IBikesRepository bikesRepository)
        {
            _bikesRepository = bikesRepository;
        }

        public Task<List<Bike>> Handle(GetBikes query)
        {
            var bikes = _bikesRepository.GetBikes().ToList();
            return Task.FromResult(bikes);
        }
    }
}
