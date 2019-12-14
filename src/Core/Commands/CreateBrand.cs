using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public class CreateBrand : ICommand
    {
        public string Name { get; set; }
        public DateTime FoundationYear { get; set; }
        public string Country { get; set; }
    }
}
