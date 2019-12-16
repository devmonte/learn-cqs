using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Core.Commands
{
    public class CreateBike : IRequest
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }
    }
}
