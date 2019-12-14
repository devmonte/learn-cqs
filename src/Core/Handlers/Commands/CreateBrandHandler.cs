using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Commands;
using Core.Models;
using Core.Repositories;

namespace Core.Handlers.Commands
{
    public class CreateBrandHandler : ICommandHandler<CreateBrand>
    {
        private readonly IBrandRepository _brandRepository;

        public CreateBrandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public Task Handle(CreateBrand command)
        {
            _brandRepository.AddBrand(new Brand
            {
                Name = command.Name
            });
            return Task.CompletedTask;
        }
    }
}
