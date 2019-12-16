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
    public class GetBikesHandler : IRequestHandler<GetBikes, List<Bike>>
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

        public Task<List<Bike>> Handle(GetBikes request, CancellationToken cancellationToken)
        {
            var bikes = _bikesRepository.GetBikes().ToList();
            return Task.FromResult(bikes);
        }
    }
}
