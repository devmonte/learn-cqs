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
    public class CreateBikeHandler : ICommandHandler<CreateBike>
    {
        private readonly IBikesRepository _bikesRepository;

        public CreateBikeHandler(IBikesRepository bikesRepository)
        {
            _bikesRepository = bikesRepository;
        }
        public Task Handle(CreateBike command)
        {
            _bikesRepository.AddBike(new Bike
            {
                Name = command.Name,
                BrandId = command.BrandId
            });
            return Task.CompletedTask;
        }
    }
}
