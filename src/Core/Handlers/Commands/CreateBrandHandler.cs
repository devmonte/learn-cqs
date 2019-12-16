using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.Commands;
using Core.Models;
using Core.Repositories;
using MediatR;

namespace Core.Handlers.Commands
{
    public class CreateBrandHandler : IRequestHandler<CreateBrand>
    {
        private readonly IBrandsRepository _brandsRepository;

        public CreateBrandHandler(IBrandsRepository brandsRepository)
        {
            _brandsRepository = brandsRepository;
        }

        public Task Handle(CreateBrand command)
        {
            _brandsRepository.AddBrand(new Brand
            {
                Name = command.Name
            });
            return Task.CompletedTask;
        }

        public Task<Unit> Handle(CreateBrand request, CancellationToken cancellationToken)
        {
            _brandsRepository.AddBrand(new Brand
            {
                Name = request.Name

            });
            return Task.FromResult(new Unit());
        }
    }
}
