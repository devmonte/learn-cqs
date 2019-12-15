using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public class CreateBike : ICommand
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }
    }
}
