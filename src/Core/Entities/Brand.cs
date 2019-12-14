using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public DateTime FoundationYear { get; set; }
        public List<Bike> Bikes { get; set; }
    }
}
